using WebScraper.Application.Models;

namespace WebScraper.Application.Services
{
    public interface ISearchPositionsService
    {
        public Task<SearchPositionsResult> GetSearchPositions(string baseUrl, string searchUrl, string regex, string keywords, string searchFor);
        public HttpClient GetHttpClient(string baseUrl);
        public string GetPositions(string content, string regex, string searchFor);
    }
}
