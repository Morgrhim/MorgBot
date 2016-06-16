using System.Collections.Generic;

namespace MorgBot.GameWispAPI.Enums
{
    interface IPagedList<T>
    {
        int Count { get; set; }
        int End { get; }
        bool HasNext { get; }
        bool HasPrev { get; }
        IEnumerable<T> List { get; set; }
        int NextPage { get; }
        int Page { get; }
        int PageCount { get; }
        int PageSize { get; }
        int PrevPage { get; }
        int Start { get; }
    }
}
