using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Telegram_Commenter.Models;
using Telegram_Commenter.Utilities;

namespace Telegram_Commenter.API
{
    public class CommentSender
    {
        private frmMain main;
        private List<string> posts;
        private List<string> comments;
        private CookieContainer session;
        private string phoneNumber;

        public CommentSender(frmMain main, CookieContainer session, List<string> posts, List<string> comments, string phoneNumber)
        {
            this.main = main;
            this.session = session;
            this.posts = posts;
            this.comments = comments;
            this.phoneNumber = phoneNumber;
        }

        public void Execute()
        {
           var request = getUserDetails(session);
            if (request.Item1)
            {
                Logger.LogMessage(main, "User details received (" + phoneNumber + ").");
                var account = JsonConvert.DeserializeObject<Account>(JToken.Parse(request.Item2)["user"].ToString());
                foreach (var post in posts)
                {
                    var request2 = getPostDetails(account, post);
                    if (request2.Item1)
                    {
                        Logger.LogMessage(main, "Post details received (" + post + ").");
                        foreach (var comment in comments)
                        {
                            sendComment(request2.Item3, request2.Item2, post.Split('/')[4], comment);
                        }
                    }
                    else
                    {
                        Logger.LogMessage(main, "Error receiving post details (" + post + ").");
                        Logger.LogError(request.Item2);
                    }
                }
            }
            else if (!request.Item1 && !string.IsNullOrWhiteSpace(request.Item2))
            {
                Logger.LogMessage(main, "Error getting user details (" + phoneNumber + ").");
                Logger.LogError(request.Item2);
            }
        }

        private Tuple<bool, string> getUserDetails(CookieContainer session)
        {
            try
            {
                var buffer2 = Encoding.ASCII.GetBytes("origin=https%3A%2F%2Fcomments.app&request_access=write");
                var request2 = (HttpWebRequest)WebRequest.Create("https://oauth.telegram.org/auth/get?bot_id=" + Globals.BotId + "&lang=en");
                request2.Method = "POST";
                request2.CookieContainer = session;
                request2.ContentType = Globals.DefaultContentType;
                request2.UserAgent = Globals.UserAgent;
                request2.Headers.Add("X-Requested-With", "XMLHttpRequest");

                var requestStream2 = request2.GetRequestStream();
                requestStream2.Write(buffer2, 0, buffer2.Length);
                requestStream2.Close();

                var response2 = (HttpWebResponse)request2.GetResponse();
                var responseString2 = new StreamReader(response2.GetResponseStream()).ReadToEnd();
                var user = JToken.Parse(responseString2)["user"];

                return new Tuple<bool, string>(user != null, responseString2);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
        }

        private Tuple<bool, string, CookieContainer> getPostDetails(Account account, string post)
        {
            try
            {
                var request3 = (HttpWebRequest)WebRequest.Create(post + "?id=" + account.id + "&auth_date=" + account.auth_date + "&hash=" + account.hash + (account.first_name != null ? "&first_name=" + account.first_name : string.Empty) + (account.last_name != null ? "&last_name=" + account.last_name : string.Empty) + (account.username != null ? "&username=" + account.username : string.Empty) + (account.photo_url != null ? "&photo_url=" + account.photo_url : string.Empty));
                request3.Method = "GET";
                request3.CookieContainer = session;
                request3.UserAgent = Globals.UserAgent;

                var response3 = (HttpWebResponse)request3.GetResponse();
                var responseString3 = new StreamReader(response3.GetResponseStream()).ReadToEnd();
                var apiHash = Regex.Match(responseString3, "api_hash=(.*)\"").Groups[1].Value;

                return new Tuple<bool, string, CookieContainer>(true, apiHash, session);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string, CookieContainer>(false, ex.Message, null);
            }
        }

        private void sendComment(CookieContainer session, string apiHash, string threadId, string commentText)
        {
        retry:
            if (!Statistics.WorkStatus)
                return;
            try
            {
                var buffer = Encoding.UTF8.GetBytes("thread_id=" + threadId + "&reply_to_id=&after_id=0&text=" + commentText + "&file=&method=submitNewComment");

                var request = (HttpWebRequest)WebRequest.Create("https://comments.app/api?api_hash=" + apiHash);
                request.Method = "POST";
                request.CookieContainer = session;
                request.ContentType = Globals.DefaultContentType;
                request.UserAgent = Globals.UserAgent;

                var requestStream = request.GetRequestStream();
                requestStream.Write(buffer, 0, buffer.Length);
                requestStream.Close();

                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var json = JToken.Parse(responseString);

                try
                {
                    Statistics.Trys++;
                    if ((bool)json["ok"])
                    {
                        Statistics.TotalSends++;
                        Logger.LogMessage(main, "A comment (comment text: " + commentText + ") sent to  (" + threadId + ") with " + phoneNumber + ".");
                    }
                    else if (json["error"].ToString() == "Sorry, too many attempts. Please try again later")
                    {
                        Logger.LogMessage(main, "Your IP banned for 1 min (on sending comment to " + threadId + ").");
                        Thread.Sleep(60000);
                        goto retry;
                    }
                    else
                    {
                        Statistics.Trys++;
                        Logger.LogError(responseString);
                    }
                }
                catch { }
            }
            catch (Exception ex)
            {
                Statistics.Trys++;
                Logger.LogError(ex.Message);
                goto retry;
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
