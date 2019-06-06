namespace Telegram_Commenter
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoadNumbers = new System.Windows.Forms.Button();
            this.btnLoadPosts = new System.Windows.Forms.Button();
            this.btnLoadComments = new System.Windows.Forms.Button();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListView();
            this.chPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAccountsNeedVerify = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.btnRemoveDup = new System.Windows.Forms.Button();
            this.btnMinToTray = new System.Windows.Forms.Button();
            this.btnRestartApp = new System.Windows.Forms.Button();
            this.btnRunNewTask = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblSplitter = new System.Windows.Forms.Label();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblActiveThreads = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalSends = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTrys = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPosts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPhoneNumbers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrWatch = new System.Windows.Forms.Timer(this.components);
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.icnMin = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExitSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLogs = new System.Windows.Forms.GroupBox();
            this.btnLoadAccountsBySessions = new System.Windows.Forms.Button();
            this.btnExportSessions = new System.Windows.Forms.Button();
            this.visualStyler = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.grpInputs.SuspendLayout();
            this.grpAccountsNeedVerify.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpStatistics.SuspendLayout();
            this.cmsMin.SuspendLayout();
            this.grpLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Sending";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLoadNumbers
            // 
            this.btnLoadNumbers.Location = new System.Drawing.Point(6, 21);
            this.btnLoadNumbers.Name = "btnLoadNumbers";
            this.btnLoadNumbers.Size = new System.Drawing.Size(116, 28);
            this.btnLoadNumbers.TabIndex = 0;
            this.btnLoadNumbers.Text = "Load Numbers";
            this.btnLoadNumbers.UseVisualStyleBackColor = true;
            this.btnLoadNumbers.Click += new System.EventHandler(this.btnLoadNumbers_Click);
            // 
            // btnLoadPosts
            // 
            this.btnLoadPosts.Location = new System.Drawing.Point(128, 21);
            this.btnLoadPosts.Name = "btnLoadPosts";
            this.btnLoadPosts.Size = new System.Drawing.Size(116, 28);
            this.btnLoadPosts.TabIndex = 1;
            this.btnLoadPosts.Text = "Load Posts";
            this.btnLoadPosts.UseVisualStyleBackColor = true;
            this.btnLoadPosts.Click += new System.EventHandler(this.btnLoadPosts_Click);
            // 
            // btnLoadComments
            // 
            this.btnLoadComments.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoadComments.Location = new System.Drawing.Point(250, 21);
            this.btnLoadComments.Name = "btnLoadComments";
            this.btnLoadComments.Size = new System.Drawing.Size(116, 28);
            this.btnLoadComments.TabIndex = 2;
            this.btnLoadComments.Text = "Load Comments";
            this.btnLoadComments.UseVisualStyleBackColor = true;
            this.btnLoadComments.Click += new System.EventHandler(this.btnLoadComments_Click);
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.btnLoadPosts);
            this.grpInputs.Controls.Add(this.btnClearAll);
            this.grpInputs.Controls.Add(this.btnLoadComments);
            this.grpInputs.Controls.Add(this.btnExportSessions);
            this.grpInputs.Controls.Add(this.btnLoadAccountsBySessions);
            this.grpInputs.Controls.Add(this.btnLoadNumbers);
            this.grpInputs.Location = new System.Drawing.Point(12, 47);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(447, 91);
            this.grpInputs.TabIndex = 2;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Inputs";
            // 
            // btnClearAll
            // 
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearAll.Location = new System.Drawing.Point(372, 21);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(69, 28);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lstAccounts
            // 
            this.lstAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAccounts.BackColor = System.Drawing.Color.White;
            this.lstAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPhoneNumber,
            this.chStatus});
            this.lstAccounts.FullRowSelect = true;
            this.lstAccounts.GridLines = true;
            this.lstAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstAccounts.HideSelection = false;
            this.lstAccounts.Location = new System.Drawing.Point(6, 21);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(258, 159);
            this.lstAccounts.TabIndex = 0;
            this.lstAccounts.UseCompatibleStateImageBehavior = false;
            this.lstAccounts.View = System.Windows.Forms.View.Details;
            // 
            // chPhoneNumber
            // 
            this.chPhoneNumber.Text = "Phone number";
            this.chPhoneNumber.Width = 100;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 150;
            // 
            // grpAccountsNeedVerify
            // 
            this.grpAccountsNeedVerify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAccountsNeedVerify.Controls.Add(this.lstAccounts);
            this.grpAccountsNeedVerify.Location = new System.Drawing.Point(12, 206);
            this.grpAccountsNeedVerify.Name = "grpAccountsNeedVerify";
            this.grpAccountsNeedVerify.Size = new System.Drawing.Size(270, 187);
            this.grpAccountsNeedVerify.TabIndex = 4;
            this.grpAccountsNeedVerify.TabStop = false;
            this.grpAccountsNeedVerify.Text = "Accounts need verify";
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Location = new System.Drawing.Point(128, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Sending";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnStart);
            this.grpControls.Controls.Add(this.btnSaveLogs);
            this.grpControls.Controls.Add(this.btnRemoveDup);
            this.grpControls.Controls.Add(this.btnStop);
            this.grpControls.Location = new System.Drawing.Point(12, 144);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(447, 56);
            this.grpControls.TabIndex = 3;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.Location = new System.Drawing.Point(372, 21);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(69, 28);
            this.btnSaveLogs.TabIndex = 3;
            this.btnSaveLogs.Text = "Save logs";
            this.btnSaveLogs.UseVisualStyleBackColor = true;
            this.btnSaveLogs.Click += new System.EventHandler(this.btnSaveLogs_Click);
            // 
            // btnRemoveDup
            // 
            this.btnRemoveDup.Location = new System.Drawing.Point(250, 21);
            this.btnRemoveDup.Name = "btnRemoveDup";
            this.btnRemoveDup.Size = new System.Drawing.Size(116, 28);
            this.btnRemoveDup.TabIndex = 2;
            this.btnRemoveDup.Text = "Remove dup (s)";
            this.btnRemoveDup.UseVisualStyleBackColor = true;
            this.btnRemoveDup.Click += new System.EventHandler(this.btnRemoveDup_Click);
            // 
            // btnMinToTray
            // 
            this.btnMinToTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinToTray.Location = new System.Drawing.Point(477, 6);
            this.btnMinToTray.Name = "btnMinToTray";
            this.btnMinToTray.Size = new System.Drawing.Size(90, 23);
            this.btnMinToTray.TabIndex = 7;
            this.btnMinToTray.Text = "Min to tray";
            this.btnMinToTray.UseVisualStyleBackColor = true;
            this.btnMinToTray.Click += new System.EventHandler(this.btnMinToTray_Click);
            // 
            // btnRestartApp
            // 
            this.btnRestartApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestartApp.Location = new System.Drawing.Point(569, 6);
            this.btnRestartApp.Name = "btnRestartApp";
            this.btnRestartApp.Size = new System.Drawing.Size(90, 23);
            this.btnRestartApp.TabIndex = 8;
            this.btnRestartApp.Text = "Restart app";
            this.btnRestartApp.UseVisualStyleBackColor = true;
            this.btnRestartApp.Click += new System.EventHandler(this.btnRestartApp_Click);
            // 
            // btnRunNewTask
            // 
            this.btnRunNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunNewTask.Location = new System.Drawing.Point(661, 6);
            this.btnRunNewTask.Name = "btnRunNewTask";
            this.btnRunNewTask.Size = new System.Drawing.Size(90, 23);
            this.btnRunNewTask.TabIndex = 9;
            this.btnRunNewTask.Text = "Run new task";
            this.btnRunNewTask.UseVisualStyleBackColor = true;
            this.btnRunNewTask.Click += new System.EventHandler(this.btnRunNewTask_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAboutUs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAboutUs.Location = new System.Drawing.Point(753, 6);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(90, 23);
            this.btnAboutUs.TabIndex = 10;
            this.btnAboutUs.Text = "About us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(9, 11);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(309, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Desc this tool: A tool for send comments to Telegram posts";
            // 
            // lblSplitter
            // 
            this.lblSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSplitter.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblSplitter.Location = new System.Drawing.Point(0, 35);
            this.lblSplitter.Name = "lblSplitter";
            this.lblSplitter.Size = new System.Drawing.Size(849, 1);
            this.lblSplitter.TabIndex = 1;
            // 
            // grpStatistics
            // 
            this.grpStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpStatistics.Controls.Add(this.lblElapsedTime);
            this.grpStatistics.Controls.Add(this.label8);
            this.grpStatistics.Controls.Add(this.lblActiveThreads);
            this.grpStatistics.Controls.Add(this.label7);
            this.grpStatistics.Controls.Add(this.lblErrors);
            this.grpStatistics.Controls.Add(this.label6);
            this.grpStatistics.Controls.Add(this.lblTotalSends);
            this.grpStatistics.Controls.Add(this.label5);
            this.grpStatistics.Controls.Add(this.lblTrys);
            this.grpStatistics.Controls.Add(this.label4);
            this.grpStatistics.Controls.Add(this.lblComments);
            this.grpStatistics.Controls.Add(this.label3);
            this.grpStatistics.Controls.Add(this.lblPosts);
            this.grpStatistics.Controls.Add(this.label2);
            this.grpStatistics.Controls.Add(this.lblPhoneNumbers);
            this.grpStatistics.Controls.Add(this.label1);
            this.grpStatistics.Location = new System.Drawing.Point(288, 206);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(171, 187);
            this.grpStatistics.TabIndex = 5;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "Statistics";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Location = new System.Drawing.Point(99, 163);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(66, 13);
            this.lblElapsedTime.TabIndex = 15;
            this.lblElapsedTime.Text = "00:00:00";
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Elapsed time:";
            // 
            // lblActiveThreads
            // 
            this.lblActiveThreads.Location = new System.Drawing.Point(99, 143);
            this.lblActiveThreads.Name = "lblActiveThreads";
            this.lblActiveThreads.Size = new System.Drawing.Size(66, 13);
            this.lblActiveThreads.TabIndex = 13;
            this.lblActiveThreads.Text = "0";
            this.lblActiveThreads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Active threads:";
            // 
            // lblErrors
            // 
            this.lblErrors.Location = new System.Drawing.Point(99, 123);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(66, 13);
            this.lblErrors.TabIndex = 11;
            this.lblErrors.Text = "0";
            this.lblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Errors:";
            // 
            // lblTotalSends
            // 
            this.lblTotalSends.Location = new System.Drawing.Point(99, 103);
            this.lblTotalSends.Name = "lblTotalSends";
            this.lblTotalSends.Size = new System.Drawing.Size(66, 13);
            this.lblTotalSends.TabIndex = 9;
            this.lblTotalSends.Text = "0";
            this.lblTotalSends.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total sends:";
            // 
            // lblTrys
            // 
            this.lblTrys.Location = new System.Drawing.Point(99, 83);
            this.lblTrys.Name = "lblTrys";
            this.lblTrys.Size = new System.Drawing.Size(66, 13);
            this.lblTrys.TabIndex = 7;
            this.lblTrys.Text = "0";
            this.lblTrys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Try (s):";
            // 
            // lblComments
            // 
            this.lblComments.Location = new System.Drawing.Point(99, 63);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(66, 13);
            this.lblComments.TabIndex = 5;
            this.lblComments.Text = "0";
            this.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comments:";
            // 
            // lblPosts
            // 
            this.lblPosts.Location = new System.Drawing.Point(99, 43);
            this.lblPosts.Name = "lblPosts";
            this.lblPosts.Size = new System.Drawing.Size(66, 13);
            this.lblPosts.TabIndex = 3;
            this.lblPosts.Text = "0";
            this.lblPosts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posts:";
            // 
            // lblPhoneNumbers
            // 
            this.lblPhoneNumbers.Location = new System.Drawing.Point(99, 23);
            this.lblPhoneNumbers.Name = "lblPhoneNumbers";
            this.lblPhoneNumbers.Size = new System.Drawing.Size(66, 13);
            this.lblPhoneNumbers.TabIndex = 1;
            this.lblPhoneNumbers.Text = "0";
            this.lblPhoneNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone numbers:";
            // 
            // tmrWatch
            // 
            this.tmrWatch.Interval = 1000;
            this.tmrWatch.Tick += new System.EventHandler(this.tmrWatch_Tick);
            // 
            // txtLogs
            // 
            this.txtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogs.Location = new System.Drawing.Point(6, 21);
            this.txtLogs.MaxLength = 999999999;
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(360, 319);
            this.txtLogs.TabIndex = 0;
            // 
            // icnMin
            // 
            this.icnMin.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icnMin.BalloonTipText = "Telegram Commenter minimzed to tray.";
            this.icnMin.BalloonTipTitle = "Minimized";
            this.icnMin.ContextMenuStrip = this.cmsMin;
            this.icnMin.Icon = ((System.Drawing.Icon)(resources.GetObject("icnMin.Icon")));
            this.icnMin.Visible = true;
            this.icnMin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icnMin_MouseDoubleClick);
            // 
            // cmsMin
            // 
            this.cmsMin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowSoftware,
            this.tsmiExitSoftware});
            this.cmsMin.Name = "cmsMin";
            this.cmsMin.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsMin.Size = new System.Drawing.Size(152, 48);
            // 
            // tsmiShowSoftware
            // 
            this.tsmiShowSoftware.Name = "tsmiShowSoftware";
            this.tsmiShowSoftware.Size = new System.Drawing.Size(151, 22);
            this.tsmiShowSoftware.Text = "Show software";
            this.tsmiShowSoftware.Click += new System.EventHandler(this.tsmiShowSoftware_Click);
            // 
            // tsmiExitSoftware
            // 
            this.tsmiExitSoftware.Name = "tsmiExitSoftware";
            this.tsmiExitSoftware.Size = new System.Drawing.Size(151, 22);
            this.tsmiExitSoftware.Text = "Exit software";
            this.tsmiExitSoftware.Click += new System.EventHandler(this.tsmiExitSoftware_Click);
            // 
            // grpLogs
            // 
            this.grpLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLogs.Controls.Add(this.txtLogs);
            this.grpLogs.Location = new System.Drawing.Point(465, 47);
            this.grpLogs.Name = "grpLogs";
            this.grpLogs.Size = new System.Drawing.Size(372, 346);
            this.grpLogs.TabIndex = 6;
            this.grpLogs.TabStop = false;
            this.grpLogs.Text = "Logs";
            // 
            // btnLoadAccountsBySessions
            // 
            this.btnLoadAccountsBySessions.Location = new System.Drawing.Point(6, 55);
            this.btnLoadAccountsBySessions.Name = "btnLoadAccountsBySessions";
            this.btnLoadAccountsBySessions.Size = new System.Drawing.Size(238, 28);
            this.btnLoadAccountsBySessions.TabIndex = 4;
            this.btnLoadAccountsBySessions.Text = "Load accounts by sessions";
            this.btnLoadAccountsBySessions.UseVisualStyleBackColor = true;
            this.btnLoadAccountsBySessions.Click += new System.EventHandler(this.btnLoadAccountsBySessions_Click);
            // 
            // btnExportSessions
            // 
            this.btnExportSessions.Location = new System.Drawing.Point(250, 55);
            this.btnExportSessions.Name = "btnExportSessions";
            this.btnExportSessions.Size = new System.Drawing.Size(191, 28);
            this.btnExportSessions.TabIndex = 5;
            this.btnExportSessions.Text = "Export sessions";
            this.btnExportSessions.UseVisualStyleBackColor = true;
            this.btnExportSessions.Click += new System.EventHandler(this.btnExportSessions_Click);
            // 
            // visualStyler
            // 
            this.visualStyler.HostForm = this;
            this.visualStyler.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler.License")));
            this.visualStyler.ShadowStyle = SkinSoft.VisualStyler.ShadowStyle.Medium;
            this.visualStyler.ShowFocusCues = false;
            this.visualStyler.SkinCommonDialogs = false;
            this.visualStyler.LoadVisualStyle(null, "Kupo XP 2 Red (Normal).vssf");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 404);
            this.Controls.Add(this.lblSplitter);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnRestartApp);
            this.Controls.Add(this.btnRunNewTask);
            this.Controls.Add(this.btnMinToTray);
            this.Controls.Add(this.grpStatistics);
            this.Controls.Add(this.grpLogs);
            this.Controls.Add(this.grpAccountsNeedVerify);
            this.Controls.Add(this.grpInputs);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(865, 443);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram Commenter by RP SOFT (BETA)";
            this.grpInputs.ResumeLayout(false);
            this.grpAccountsNeedVerify.ResumeLayout(false);
            this.grpControls.ResumeLayout(false);
            this.grpStatistics.ResumeLayout(false);
            this.grpStatistics.PerformLayout();
            this.cmsMin.ResumeLayout(false);
            this.grpLogs.ResumeLayout(false);
            this.grpLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLoadNumbers;
        private System.Windows.Forms.Button btnLoadPosts;
        private System.Windows.Forms.Button btnLoadComments;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.ListView lstAccounts;
        private System.Windows.Forms.ColumnHeader chPhoneNumber;
        private System.Windows.Forms.GroupBox grpAccountsNeedVerify;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnMinToTray;
        private System.Windows.Forms.Button btnRestartApp;
        private System.Windows.Forms.Button btnRemoveDup;
        private System.Windows.Forms.Button btnRunNewTask;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblSplitter;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chStatus;
        public System.Windows.Forms.Label lblElapsedTime;
        public System.Windows.Forms.Label lblActiveThreads;
        public System.Windows.Forms.Label lblErrors;
        public System.Windows.Forms.Label lblTotalSends;
        public System.Windows.Forms.Label lblTrys;
        public System.Windows.Forms.Label lblComments;
        public System.Windows.Forms.Label lblPosts;
        public System.Windows.Forms.Label lblPhoneNumbers;
        private System.Windows.Forms.Timer tmrWatch;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSaveLogs;
        private System.Windows.Forms.NotifyIcon icnMin;
        private System.Windows.Forms.ContextMenuStrip cmsMin;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowSoftware;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitSoftware;
        public System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.GroupBox grpLogs;
        private System.Windows.Forms.Button btnExportSessions;
        private System.Windows.Forms.Button btnLoadAccountsBySessions;
        private SkinSoft.VisualStyler.VisualStyler visualStyler;
    }
}

