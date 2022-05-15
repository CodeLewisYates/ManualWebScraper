namespace WebScraper.API.Dtos
{
    public class SearchPositionsDto
    {
        public string Keywords { get; set; } = string.Empty;
        public string SearchFor { get; set; } = string.Empty;
        public int SearchEngineId { get; set; }
    }
}
