using Newtonsoft.Json;

namespace SlackSharp.Rtm
{
    public class SlackRtmReplyMessage
    {
        public bool Ok { get; set; }
    
        [JsonProperty(PropertyName = "reply_to")]
        public int ReplyTo { get; set; }
    
        ///<summary>
        /// In the case of a reply to a chat message, if successful, the reply will contain the canonical recorded timestamp of the message. All messages within a single channel are guaranteed to have a unique timestamp which is ASCII sortable. Given the precision of the timestamp, clients should treat these timestamps as strings, not floats/doubles. Once a successful reply has been returned, the message in the chat log should no longer be grayed out - it has now been delivered.
        ///</summary>
        [JsonProperty(PropertyName = "ts")]
        public string TimeStamp { get; set; }
    
        public string Text { get; set; }
    }
}