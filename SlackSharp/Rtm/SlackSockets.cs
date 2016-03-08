using System.Collections.Generic;
using Newtonsoft.Json;
using SlackSharp.Rtm;
using SlackSharp.Rtm.Events;
using WebSocketSharp;
using SlackSharp.Serializer;
using System.Threading.Tasks;

namespace SlackSharp.Rtm
{
    public static class SlackSockets
    {
        public static List<WebSocket> WebSockets = new List<WebSocket>();

        public static WebSocket New(string url)
        {
            var ws = new WebSocket(url);
            WebSockets.Add(ws);
            return ws;
        }
    }

    public class SlackSocket
    {
        public static List<SlackSocket> Sockets = new List<SlackSocket>();

        public event HelloHandler OnHello;
        public event MessageHandler OnMessage;
        public event MessageHandlerAsync OnMessageAsync;
        public event UserTypingHandler OnUserTyping;
        public event ErrorHandler OnError;

        public delegate void HelloHandler(SlackSocket m, SlackRtmEvent e);
        public delegate void MessageHandler(SlackSocket m, SlackRtmEventMessage e);
        public delegate void UserTypingHandler(SlackSocket m, SlackRtmEventUserTyping e);
        public delegate void ErrorHandler(SlackSocket m, SlackRtmEventError e);

        public delegate Task MessageHandlerAsync(SlackSocket m, SlackRtmEventMessage e);


        private readonly WebSocket _webSocket;

        public SlackSocket(string url)
        {
            _webSocket = new WebSocket(url);
            Sockets.Add(this);
            SetupListeners();
        }

        public void Connect()
        {
            _webSocket.Connect();
        }

        private void SetupListeners()
        {
            _webSocket.OnOpen += (sender, e) =>
            {
            };

            _webSocket.OnMessage += (sender, e) =>
            {
                if (e.Type == Opcode.Text)
                {

                    try
                    {
                        SwitchEvents(JsonConvert.DeserializeObject<SlackRtmEvent>(e.Data), e);
                    }
                    catch (JsonSerializationException exception)
                    {
                    }

                    return;
                }

                if (e.Type == Opcode.Binary)
                {
                    // Do something with e.RawData.
                    return;
                }
            };

            _webSocket.OnError += (sender, e) =>
            {
            };

            _webSocket.OnClose += (sender, e) =>
            {
            };
        }

        public void Send(SlackRtmSendMessage message)
        {
            var serialized = SlackJsonSerializer.SerializeObject(message);
            _webSocket.Send(serialized);
        }

        public async Task SwitchEvents(SlackRtmEvent e, MessageEventArgs args)
        {
            switch (e.Type)
            {
                case SlackRtmEventType.Hello:
                    OnHello?.Invoke(this, e);
                    break;
                case SlackRtmEventType.Message:
                    OnMessage?.Invoke(this, JsonConvert.DeserializeObject<SlackRtmEventMessage>(args.Data));
                    await OnMessageAsync?.Invoke(this, JsonConvert.DeserializeObject<SlackRtmEventMessage>(args.Data));
                    break;
                case SlackRtmEventType.UserTyping:
                    OnUserTyping?.Invoke(this, JsonConvert.DeserializeObject<SlackRtmEventUserTyping>(args.Data));
                    break;
                case SlackRtmEventType.Error:
                    OnError?.Invoke(this, JsonConvert.DeserializeObject<SlackRtmEventError>(args.Data));
                    break;
            }
        }
    }
}
