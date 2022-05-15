
using WebScraper.Application.Models;

namespace WebScraper.Application.Services
{
    public interface ISearchHistoryService
    {
        public Task<List<SearchHistoryResult>> GetSearchHistory();

        public Task<SearchHistoryResult> InsertIntoSearchHistory(string searchEngineUsed, string keywords, string searchedFor, string positions);
    }
}
