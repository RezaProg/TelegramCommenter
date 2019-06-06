using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace Telegram_Commenter.Utilities
{
    public static class CookiesHelper
    {
        public static string GetCookies(CookieContainer cookieContainer)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    new BinaryFormatter().Serialize(stream, cookieContainer);
                    var bytes = new byte[stream.Length];
                    stream.Position = 0;
                    stream.Read(bytes, 0, bytes.Length);
                    return Convert.ToBase64String(bytes);
                }
            }
            catch { return string.Empty; }
        }

        public static bool SetCookies(ref CookieContainer cookieContainer, string cookieText)
        {
            try
            {
                using (var stream = new MemoryStream(Convert.FromBase64String(cookieText)))
                {
                    cookieContainer = (CookieContainer)new BinaryFormatter().Deserialize(stream);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
