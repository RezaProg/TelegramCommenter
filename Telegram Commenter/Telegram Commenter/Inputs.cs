using System;
using System.Collections.Generic;
using Telegram_Commenter.Models;

namespace Telegram_Commenter
{
    public class Inputs
    {
        private string minThreads;
        private string maxThreads;
        private string commentPerPost;

        public string MinThreads
        {
            get { return minThreads; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new Exception(Globals.ErrorMessage_MinimumThreadNull);
                }
                if (!int.TryParse(value.ToString(), out int s))
                {
                    throw new Exception(Globals.ErrorMessage_MinimumThreadInvalid);
                }
                minThreads = value;
            }
        }

        public string MaxThreads
        {
            get { return maxThreads; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new Exception(Globals.ErrorMessage_MaximumThreadNull);
                }
                if (!int.TryParse(value.ToString(), out int s))
                {
                    throw new Exception(Globals.ErrorMessage_MaximumThreadInvalid);
                }
                maxThreads = value;
            }
        }

        public string CommentPerPost
        {
            get { return commentPerPost; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new Exception(Globals.ErrorMessage_CommentPerPostNull);
                }
                if (!int.TryParse(value.ToString(), out int i))
                {
                    throw new Exception(Globals.ErrorMessage_CommentPerPostInvalid);
                }
                commentPerPost = value;
            }
        }

        public List<string> PhoneNumbers = new List<string>();

        public List<string> Posts = new List<string>();

        public List<string> Comments = new List<string>();

        public List<SAccount> SAccounts = new List<SAccount>();
    }
}
