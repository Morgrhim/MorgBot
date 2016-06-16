using RestSharp;

namespace MorgBot.TwitchAPI.Clients
{
    public interface ITwitchClient
    {
        RestRequest GetRequest(string url, Method method);
    }
}
