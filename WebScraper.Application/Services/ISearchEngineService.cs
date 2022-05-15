using WebScraper.Application.Models;

namespace WebScraper.Application.Services
{
    public interface ISearchEngineService
    {
        public Task<SearchEngineResult> GetSearchEngineById(int searchEngineId);
        public Task<List<SearchEngineResult>> GetAllSearchEngines();
    }
}
