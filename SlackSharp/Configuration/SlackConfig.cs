using System.Configuration;

namespace SlackSharp.Configuration
{
    public class SlackApiConfigurationAppSettings : ISlackApiConfiguration
    {
        public string Url => ConfigurationManager.AppSettings["SlackApi:Url"];
        public string Token => ConfigurationManager.AppSettings["SlackApi:Token"];
    }
}
