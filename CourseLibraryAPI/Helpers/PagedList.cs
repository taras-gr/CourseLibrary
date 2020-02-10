using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CourseLibraryAPI.Helpers
{
    [JsonObject]
    public class PagedList<T> : List<T>
    {
        [JsonProperty]
        public int CurrentPage { get; private set; }
        [JsonProperty]
        public int TotalPages { get; private set; }
        [JsonProperty]
        public int PageSize { get; private set; }
        [JsonProperty]
        public int TotalCount { get; private set; }
        [JsonProperty]
        public bool HasPrevious => (CurrentPage > 1);
        [JsonProperty]
        public bool HasNext => (CurrentPage < TotalPages);

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }

        public static PagedList<T> Create(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
