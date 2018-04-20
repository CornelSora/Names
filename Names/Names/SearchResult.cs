using SQLite;

namespace Names
{
    public class SearchResult
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Keyword { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public int Count { get; set; }
    }
}
