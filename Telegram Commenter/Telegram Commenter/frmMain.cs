using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Telegram_Commenter.API;
using Telegram_Commenter.Models;
using Telegram_Commenter.Utilities;

namespace Telegram_Commenter
{
    public partial class frmMain : Form
    {
        private Thread commenter;
        private Stopwatch watch = new Stopwatch();
        private Inputs inputs = new Inputs();
        private List<string> tempSessions = new List<string>();

        public frmMain()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = false;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Globals.AboutText, "About us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRunNewTask_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Logger.LogMessage(this, "New task runned.");
        }

        private void btnRestartApp_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnMinToTray_Click(object sender, EventArgs e)
        {
            Hide();
            icnMin.Visible = true;
            icnMin.ShowBalloonTip(1000);

            Logger.LogMessage(this, "Minimized to tray.");
        }

        private void icnMin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            icnMin.Visible = false;
        }

        private void tsmiShowSoftware_Click(object sender, EventArgs e)
        {
            Show();
            icnMin.Visible = false;
        }

        private void tsmiExitSoftware_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadNumbers_Click(object sender, EventArgs e)
        {
            if (inputs.PhoneNumbers.Count != 0)
            {
                if (MessageBox.Show(Globals.ClearPreviousList, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    inputs.PhoneNumbers.Clear();
                    lstAccounts.Items.Clear();

                    Logger.LogMessage(this, "Phone numbers cleared.");
                }
            }
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Load numbers",
                Filter = Globals.TextFileFilter
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var phoneNumber in File.ReadAllLines(ofd.FileName))
                {
                    if (Validator.IsValidPhoneNumber(phoneNumber))
                    {
                        inputs.PhoneNumbers.Add(phoneNumber);
                    }
                }
                Logger.LogMessage(this, inputs.PhoneNumbers.Count + " phone numbers loaded.");
            }
            lblPhoneNumbers.Text = inputs.PhoneNumbers.Count.ToString();

            foreach (var phoneNumber in inputs.PhoneNumbers)
            {
                var item = new ListViewItem(new string[] { phoneNumber, "Waiting for starting" });
                lstAccounts.Items.Add(item);
            }
        }

        private void btnLoadPosts_Click(object sender, EventArgs e)
        {
            if (inputs.Posts.Count != 0)
            {
                if (MessageBox.Show(Globals.ClearPreviousList, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    inputs.Posts.Clear();
                    Logger.LogMessage(this, "Posts cleared.");
                }
            }
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Load posts",
                Filter = Globals.TextFileFilter
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var post in File.ReadAllLines(ofd.FileName))
                {
                    if (Validator.IsValidPost(post))
                    {
                        inputs.Posts.Add(post);
                    }
                }
                Logger.LogMessage(this, inputs.Posts.Count + " posts loaded.");
            }
            lblPosts.Text = inputs.Posts.Count.ToString();
        }

        private void btnLoadComments_Click(object sender, EventArgs e)
        {
            if (inputs.Comments.Count != 0)
            {
                if (MessageBox.Show(Globals.ClearPreviousList, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    inputs.Comments.Clear();
                    Logger.LogMessage(this, "Comments cleared.");
                }
            }
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Load comments",
                Filter = Globals.TextFileFilter
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var comment in File.ReadAllLines(ofd.FileName))
                {
                    if (Validator.IsValidComment(comment))
                    {
                        inputs.Comments.Add(comment);
                    }
                }
                Logger.LogMessage(this, inputs.Comments.Count + " comments loaded.");
            }
            lblComments.Text = inputs.Comments.Count.ToString();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtLogs.Clear();
            lstAccounts.Items.Clear();
            inputs.PhoneNumbers.Clear();
            inputs.Posts.Clear();
            inputs.Comments.Clear();

            lblPhoneNumbers.Text = "0";
            lblPosts.Text = "0";
            lblComments.Text = "0";

            Statistics.Trys = 0;
            Statistics.TotalSends = 0;
            Statistics.Errors = 0;
            Statistics.ActiveThreads = 0;
            Statistics.ElapsedTime = "00:00:00";
            Statistics.UpdateUI(this);

            Logger.LogMessage(this, "Everything cleared.");
        }

        private void btnLoadAccountsBySessions_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Load accounts by sessions",
                Filter = Globals.SessionFileFilter
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var line in File.ReadAllLines(ofd.FileName))
                {
                    string[] array = line.Split(':');
                    CookieContainer session = null;
                    CookiesHelper.SetCookies(ref session, array[1]);
                    inputs.SAccounts.Add(new SAccount() { PhoneNumber = array[0], Session = session });
                }
                Logger.LogMessage(this, inputs.SAccounts.Count + " accounts loaded from sessions.");
            }
            lblPhoneNumbers.Text = inputs.SAccounts.Count.ToString();

            foreach (var account in inputs.SAccounts)
            {
                var item = new ListViewItem(new string[] { account.PhoneNumber, "Accepted" });
                lstAccounts.Items.Add(item);
            }
        }

        private void btnExportSessions_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Export sessions",
                Filter = Globals.SessionFileFilter
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sfd.FileName, tempSessions.ToArray());
                Logger.LogMessage(this, "Sessions exported.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAccounts.Items.Count == 0)
                {
                    MessageBox.Show(Globals.ErrorMessage_PhoneNumbersNull, Globals.ErrorMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (inputs.Posts.Count == 0)
                {
                    MessageBox.Show(Globals.ErrorMessage_PostsNull, Globals.ErrorMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (inputs.Comments.Count == 0)
                {
                    MessageBox.Show(Globals.ErrorMessage_CommentsNull, Globals.ErrorMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Logger.LogMessage(this, "Started sending.");

                Statistics.WorkStatus = true;
                Statistics.Trys = 0;
                Statistics.TotalSends = 0;
                Statistics.Errors = 0;
                Statistics.ActiveThreads = 1;
                Statistics.ElapsedTime = "00:00:00";

                tmrWatch.Start();
                watch.Restart();

                grpInputs.Enabled = false;
                btnStart.Enabled = false;
                btnRemoveDup.Enabled = false;

                //inputs.CommentPerPost = txtCommentPerPost.Text;
                //inputs.MinThreads = txtMinThreads.Text;
                //inputs.MaxThreads = txtMaxThreads.Text;

                //int minThreads = int.Parse(inputs.MinThreads);
                //int maxThreads = int.Parse(inputs.MaxThreads);

                //ThreadPool.SetMinThreads(minThreads, minThreads);
                //ThreadPool.SetMaxThreads(maxThreads, maxThreads);

                if (inputs.SAccounts.Count == 0)
                {
                    foreach (ListViewItem item in lstAccounts.Items)
                    {
                        item.SubItems[1].Text = "Waiting for accept verification";
                        item.BackColor = Color.Yellow;
                    }

                    var accountLogger = new AccountLogger(this, inputs.PhoneNumbers);
                    accountLogger.OnAcceptListener += AccountLogger_OnAcceptListener;

                    commenter = new Thread(() => { accountLogger.Execute(); })
                    {
                        IsBackground = true
                    };
                    commenter.Start();
                }
                else
                {
                    commenter = new Thread(() =>
                    {
                        foreach (var account in inputs.SAccounts)
                        {
                            var commentSender = new CommentSender(this, account.Session, inputs.Posts, inputs.Comments, account.PhoneNumber);
                            commentSender.Execute();
                        }
                    });
                    commenter.IsBackground = true;
                    commenter.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globals.ErrorMessage_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStop_Click(null, null);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try { commenter.Abort(); } catch { }

            grpInputs.Enabled = true;
            btnStart.Enabled = true;
            btnRemoveDup.Enabled = true;

            tmrWatch.Stop();
            watch.Stop();

            if (Statistics.WorkStatus)
                Logger.LogMessage(this, "Stopped sending.");

            Statistics.WorkStatus = false;
        }

        private void btnRemoveDup_Click(object sender, EventArgs e)
        {
            List<string> newPhoneNumbers = new List<string>();
            newPhoneNumbers.AddRange(inputs.PhoneNumbers.Distinct());
            inputs.PhoneNumbers.Clear();
            inputs.PhoneNumbers.AddRange(newPhoneNumbers);
            lblPhoneNumbers.Text = inputs.PhoneNumbers.Count.ToString();
            lstAccounts.Items.Clear();
            foreach (var phoneNumber in inputs.PhoneNumbers)
            {
                ListViewItem item = new ListViewItem(new string[] { phoneNumber, "Waiting for starting" });
                lstAccounts.Items.Add(item);
            }

            List<string> newPosts = new List<string>();
            newPosts.AddRange(inputs.Posts.Distinct());
            inputs.Posts.Clear();
            inputs.Posts.AddRange(newPosts);
            lblPosts.Text = inputs.Posts.Count.ToString();

            List<string> newComments = new List<string>();
            newComments.AddRange(inputs.Comments.Distinct());
            inputs.Comments.Clear();
            inputs.Comments.AddRange(newComments);
            lblComments.Text = inputs.Comments.Count.ToString();

            Logger.LogMessage(this, "Duplicates removed.");
        }

        private void btnSaveLogs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Save logs",
                Filter = Globals.TextFileFilter
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, txtLogs.Text);
                Logger.LogMessage(this, "Logs saved.");
            }
        }

        private void AccountLogger_OnAcceptListener(CookieContainer session, string phoneNumber)
        {
            Logger.LogMessage(this, phoneNumber + " successfully approved.");

            tempSessions.Add(phoneNumber + ":" + CookiesHelper.GetCookies(session));

            var item = lstAccounts.FindItemWithText(phoneNumber);
            item.SubItems[1].Text = "Accepted";
            item.BackColor = Color.Green;

            var commentSender = new CommentSender(this, session, inputs.Posts, inputs.Comments, phoneNumber);
            commentSender.Execute();
        }

        private void tmrWatch_Tick(object sender, EventArgs e)
        {
            Statistics.ElapsedTime = string.Format("{0:00}:{1:00}:{2:00}", watch.Elapsed.TotalHours, watch.Elapsed.Minutes, watch.Elapsed.Seconds);
            Statistics.UpdateUI(this);
        }
    }
}
