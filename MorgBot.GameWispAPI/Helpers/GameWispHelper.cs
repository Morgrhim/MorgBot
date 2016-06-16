using RestSharp;

namespace MorgBot.GameWispAPI.Helpers
{
    class GameWispHelper
    {
        public const string gamewispApiUrl = "https://api.gamewisp.com/pub/v1/";

        public static void AddPaging(IRestRequest request, PagingInfo pagingInfo)
        {
            if (pagingInfo == null) return;

            request.AddParameter("limit", pagingInfo.PageSize);
            request.AddParameter("offset", pagingInfo.Skip);
        }
    }
}
