using WebScraper.Data.Models;

namespace WebScraper.Application.Models
{
    public class SearchHistoryResult
    {
        public int Id { get; set; }
        public string SearchEngineUsed { get; set; } = string.Empty;
        public string Keywords { get; set; } = string.Empty;
        public string SearchedFor { get; set; } = string.Empty;
        public string Positions { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
