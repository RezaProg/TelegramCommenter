using System;
using System.Net;

namespace Telegram_Commenter.Models
{
    public class SAccount
    {
        public string PhoneNumber { get; set; }

        public CookieContainer Session { get; set; }
    }
}
