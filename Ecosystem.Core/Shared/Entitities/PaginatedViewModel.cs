using Newtonsoft.Json;

namespace Ecosystem.Shared.Entitities
{
    public class PaginatedViewModel<T>
    {
        [JsonProperty(PropertyName = "totalEntries")]
        public int TotalEntries { get; set; }

        [JsonProperty(PropertyName = "entries")]
        public IEnumerable<T> Entries { get; set; }


        public PaginatedViewModel() { }

        public PaginatedViewModel(ICollection<T> items, int totalCount)
        {
            Entries = items;
            TotalEntries = totalCount;
        }
    }
}
