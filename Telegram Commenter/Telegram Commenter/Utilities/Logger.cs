using System;
using System.IO;

namespace Telegram_Commenter.Utilities
{
    public static class Logger
    {
        public static void LogError(string errorMessage, bool addToErrors = true)
        {
            try { File.AppendAllText(Globals.ErrorLogPath, errorMessage + Environment.NewLine); } catch { }
            if (addToErrors)
                Statistics.Errors++;
        }

        public static void LogMessage(frmMain main, string message)
        {
            main.txtLogs.AppendText("[" + DateTime.Now + "] " + message + Environment.NewLine);
        }
    }
}
