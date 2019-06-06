using System;

namespace Telegram_Commenter
{
    public static class Statistics
    {
        public static int Trys;
        public static int TotalSends;
        public static int Errors;
        public static int ActiveThreads;
        public static string ElapsedTime;
        public static bool WorkStatus;

        public static void UpdateUI(frmMain main)
        {
            main.lblTrys.Text = Trys.ToString();
            main.lblTotalSends.Text = TotalSends.ToString();
            main.lblErrors.Text = Errors.ToString();
            main.lblActiveThreads.Text = ActiveThreads.ToString();
            main.lblElapsedTime.Text = ElapsedTime;

            GC.Collect();
        }
    }
}
