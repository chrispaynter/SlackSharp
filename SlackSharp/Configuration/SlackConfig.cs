using System.Configuration;

namespace SlackSharp.Configuration
{
    public static class SlackConfig
    {
        public static string Url => ConfigurationManager.AppSettings["SlackApi:Url"];
        public static string Token => ConfigurationManager.AppSettings["SlackApi:Token"];
    }
}
