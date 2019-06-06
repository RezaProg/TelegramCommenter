using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Telegram_Commenter.Utilities;

namespace Telegram_Commenter.API
{
    public class AccountLogger
    {
        private frmMain main;
        private List<string> phoneNumbers;
        private List<Thread> threads = new List<Thread>();

        public AccountLogger(frmMain main, List<string> phoneNumbers)
        {
            this.main = main;
            this.phoneNumbers = phoneNumbers;
        }

        ~AccountLogger()
        {
            foreach (var thread in threads)
            {
                try { thread.Abort(); } catch { }
            }
        }

        public void Execute()
        {
            foreach (var phoneNumber in phoneNumbers)
            {
                var request = sendVerificationRequest(phoneNumber);
                if (request.Item1)
                {
                    Logger.LogMessage(main, "Verification request sent to " + phoneNumber + ".");
                    var t = new Thread(() => { startListnerFor(request.Item3, phoneNumber); })
                    {
                        IsBackground = true
                    };
                    t.Start();
                    threads.Add(t);
                }
                else
                {
                    Logger.LogMessage(main, "Error sending verification request to " + phoneNumber + ".");
                    Logger.LogError(request.Item2);
                }
            }
        }

        private Tuple<bool, string, CookieContainer> sendVerificationRequest(string phoneNumber)
        {
            var session = new CookieContainer();
            try
            {
                var buffer = Encoding.ASCII.GetBytes("phone=" + phoneNumber);

                var request = (HttpWebRequest)WebRequest.Create("https://oauth.telegram.org/auth/request?bot_id=" + Globals.BotId + "&origin=https%3A%2F%2Fcomments.app&request_access=write");
                request.Method = "POST";
                request.CookieContainer = session;
                request.ContentType = Globals.DefaultContentType;
                request.UserAgent = Globals.UserAgent;

                var requestStream = request.GetRequestStream();
                requestStream.Write(buffer, 0, buffer.Length);
                requestStream.Close();

                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                if (responseString.Contains("true"))
                    return new Tuple<bool, string, CookieContainer>(true, string.Empty, session);
                else
                    return new Tuple<bool, string, CookieContainer>(false, responseString, session);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string, CookieContainer>(false, ex.Message, session);
            }
        }

        private void startListnerFor(CookieContainer session, string phoneNumber)
        {
            while (Statistics.WorkStatus)
            {
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://oauth.telegram.org/auth/login?bot_id=" + Globals.BotId + "&origin=https%3A%2F%2Fcomments.app&request_access=write");
                    request.Method = "POST";
                    request.ContentLength = 0;
                    request.CookieContainer = session;
                    request.ContentType = Globals.DefaultContentType;
                    request.UserAgent = Globals.UserAgent;

                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    if (responseString.Contains("true"))
                    {
                        callListener(session, phoneNumber);
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex.Message);
                }
                Thread.Sleep(1000);
            }
        }

        public delegate void Listner(CookieContainer session, string phoneNumber);
        public event Listner OnAcceptListener;

        private void callListener(CookieContainer session, string phoneNumber)
        {
            OnAcceptListener?.Invoke(session, phoneNumber);
        }
    }
}
