using System.Diagnostics;
using MorgBot.TwitchAPI.Helpers;

namespace MorgBot.TwitchAPI.OAuth
{
    public class TwitchOauth
    {
        private const string scopes = "channel_read channel_editor channel_commercial channel_subscriptions " +
                                      "channel_check_subscription chat_login";

        public void GetOauth(string clientId)
        {
            Process.Start(TwitchHelper.twitchApiUrl + "oauth2/authorize" +
                          "?response_type=token&client_id=" + clientId +
                          "&redirect_uri=https://sycopbot.morgrhim.tv" +
                          "&scope=" + scopes);
        }
    }
}
