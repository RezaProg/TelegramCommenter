using System;

namespace Telegram_Commenter
{
    public static class Globals
    {
        public static int BotId = 871831167;
        public static string CommentsLink = "https://comments.app/view/";
        public static string DefaultContentType = "application/x-www-form-urlencoded";
        public static string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";
        public static string ErrorLogPath = "error_log.txt";

        public static string AboutText = "=========Developer: RP SOFT (RezaProg)=========\r\nTelegram: RezaProg\r\nDiscord: RezaProg#0104\r\nMail: RezaProg01@Gmail.com\r\nTelegram channel: RP_SOFT\r\nWebsite: RP-SOFT.IR";
        public static string ClearPreviousList = "Clear previous loaded list?";
        public static string TextFileFilter = "Text Files (.txt)|*.txt";
        public static string SessionFileFilter = "Session Files (.ses)|*.ses";

        public static string ErrorMessage_MinimumThreadNull = "Minimum threads cannot be null.";
        public static string ErrorMessage_MaximumThreadNull = "Maximum threads cannot be null.";
        public static string ErrorMessage_CommentPerPostNull = "Comment per post cannot be null.";
        public static string ErrorMessage_MinimumThreadInvalid = "Minimum threads invalid.";
        public static string ErrorMessage_MaximumThreadInvalid = "Maximum threads invalid.";
        public static string ErrorMessage_CommentPerPostInvalid = "Comment per post invalid.";
        public static string ErrorMessage_PhoneNumbersNull = "Phone numbers cannot be null.";
        public static string ErrorMessage_PostsNull = "Posts cannot be null.";
        public static string ErrorMessage_CommentsNull = "Comments cannot be null.";
        public static string ErrorMessage_Title = "Error";
    }
}
