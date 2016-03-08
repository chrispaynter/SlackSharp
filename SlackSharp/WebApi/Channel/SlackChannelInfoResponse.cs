using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackSharp.WebApi.Channel
{
    public class SlackChannelInfoResponse : WebApiResponse
    {
        public SlackChannel Channel { get; set; }
    }
}
