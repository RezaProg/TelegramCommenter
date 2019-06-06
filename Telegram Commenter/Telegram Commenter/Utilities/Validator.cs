using System;
using System.Linq;

namespace Telegram_Commenter.Utilities
{
    public static class Validator
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsNumber);
        }

        public static bool IsValidPost(string post)
        {
            return post.Contains(Globals.CommentsLink) && !string.IsNullOrWhiteSpace(post.Split('/')[4]);
        }

        public static bool IsValidComment(string comment)
        {
            return comment.Length >= 3 && comment.Length <= 255;
        }
    }
}
