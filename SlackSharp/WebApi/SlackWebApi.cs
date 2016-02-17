﻿using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace SlackSharp.WebApi
{
    public abstract class SlackWebApi
    {
        public string ApiToken { get; set; }
        public string ApiUrl { get; set; }

        protected SlackWebApi(string apiToken, string apiUrl)
        {
            ApiToken = apiToken;
            ApiUrl = apiUrl;
        }

        public async Task<TReturnType> Post<TReturnType>(string method)
         where TReturnType : WebApiResponse
        {
            var response = await Post(method);
            return JsonConvert.DeserializeObject<TReturnType>(response);
        }

        public async Task<TReturnType> Post<TReturnType>(string method, Dictionary<string, string> postParameters) 
            where TReturnType : WebApiResponse
        {
            var response = await Post(method, postParameters);
            return JsonConvert.DeserializeObject<TReturnType>(response);
        }

        public async Task<string> Post(string method)
        {
            return await Post(method, null);
        }

        public async Task<string> Post(string method, Dictionary<string, string> postParameters)
        {
            postParameters = postParameters ?? new Dictionary<string, string>();
            postParameters.Add("token", ApiToken);

            var request = WebRequest.Create(string.Format(ApiUrl, method));
            var postString = PostString(postParameters);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postString.Length;

            var data = Encoding.ASCII.GetBytes(postString);
            var requestStream = await request.GetRequestStreamAsync();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            var response = (HttpWebResponse)await request.GetResponseAsync();
            var responseStream = response.GetResponseStream();
            var myStreamReader = new StreamReader(responseStream, Encoding.Default);
            var responseContent = await myStreamReader.ReadToEndAsync();

            myStreamReader.Close();
            responseStream.Close();
            response.Close();

            return responseContent;
        }

        private static string PostString(Dictionary<string, string> postParameters)
        {
            if (postParameters == null) return "";

            var postData = "";

            foreach (string key in postParameters.Keys)
            {
                postData += HttpUtility.UrlEncode(key) + "=" + HttpUtility.UrlEncode(postParameters[key]) + "&";
            }

            return postData.TrimEnd('&');
        }
    }
}
