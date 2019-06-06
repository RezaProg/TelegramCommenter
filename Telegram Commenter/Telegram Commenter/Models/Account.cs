using System;

namespace Telegram_Commenter.Models
{
    // For JSON deserialization
    public class Account
    {
        public int id { get; set; }

        public int auth_date { get; set; }

        public string username { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string photo_url { get; set; }

        public string hash { get; set; }
    }
}
