namespace SlackSharp.Configuration
{
    public interface ISlackApiConfiguration
    {
        string Url { get; }
        string Token { get; }
    }
}
