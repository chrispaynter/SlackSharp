﻿namespace SlackSharp.Webhooks.Outgoing
{
    public class SlackTriggerRequest
    {
        public string Token { get; set; }
        public string Team_Id { get; set; }
        public string Team_Domain { get; set; }
        public string Channel_Id { get; set; }
        public string Channel_Name { get; set; }
        public string User_Id { get; set; }
        public string User_Name { get; set; }
        public string Command { get; set; }
        public string Text { get; set; }
        public string Response_Url { get; set; }
    }
}