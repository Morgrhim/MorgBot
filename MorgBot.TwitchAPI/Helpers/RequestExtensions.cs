using RestSharp;

namespace MorgBot.TwitchAPI.Helpers
{
    public static class RequestExtensions
    {
        public static void AddSafeParameter(this IRestRequest request, string parameter, object value)
        {
            if(!string.IsNullOrEmpty(parameter) && value != null)
            {
                request.AddParameter(parameter, value);
            }
        }
    }
}
