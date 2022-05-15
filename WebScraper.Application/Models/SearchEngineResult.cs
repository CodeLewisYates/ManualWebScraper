
namespace WebScraper.Application.Models
{
    public class SearchEngineResult
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = string.Empty;
        public string SearchUrl { get; set; } = string.Empty;
        public string Regex { get; set; } = string.Empty;
    }
}
