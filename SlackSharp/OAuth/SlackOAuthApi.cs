using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SlackSharp.OAuth.Models;

namespace SlackSharp.OAuth
{
    public static class SlackOAuthApi
    {
        private static string _baseSlackUrl = "https://slack.com/api/";
        private static string _clientId = "2452041575.21078323206";
        private static string _scope = "incoming-webhook,commands,bot";
        private static string _clientSecret = "5f4c23ff6255a04061473559ac41df79";

        public static OuthAccessResponse OuthAccessResponse { get; set; }
        public static string State  { get; set; }

        static SlackOAuthApi()
        {
            State = Guid.NewGuid().ToString();
        }

        public static async Task InitiateSlackAuthentication()
        {
            if (OuthAccessResponse != null) return;

            var authUrl = _baseSlackUrl + "authorize?client_id={0}&scope={1}";
            authUrl = string.Format(authUrl, _clientId, _scope);

            var request = WebRequest.Create(authUrl);
            request.Method = "post";
            await request.GetResponseAsync();
        }

        public static async Task RequestSlackAccessToken(string code)
        {
            if (OuthAccessResponse != null) return;

            var tokenUrl = _baseSlackUrl + "oauth.access";
            string postString = string.Format("client_id={0}&code={1}&client_secret ={2}", _clientId, code, _clientSecret);

            var webRequest = WebRequest.Create(tokenUrl);
            webRequest.Method = "post";
            webRequest.ContentLength = postString.Length;

            var requestWriter = new StreamWriter(webRequest.GetRequestStream());
            requestWriter.Write(postString);
            requestWriter.Close();

            var response = await webRequest.GetResponseAsync();

            var responseReader = new StreamReader(response.GetResponseStream());
            var responseData = responseReader.ReadToEnd();

            responseReader.Close();
            webRequest.GetResponse().Close();
            OuthAccessResponse = JsonConvert.DeserializeObject<OuthAccessResponse>(responseData);
        }
    }
}