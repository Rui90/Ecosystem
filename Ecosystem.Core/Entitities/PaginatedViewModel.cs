namespace Core.Entitities
{
    public class PaginatedViewModel<T>
    {
        public int TotalEntries { get; set; }

        public IEnumerable<T> Entries { get; set; }

        public PaginatedViewModel(ICollection<T> items, int totalCount)
        {
            Entries = items;
            TotalEntries = totalCount;
        }
    }
}
