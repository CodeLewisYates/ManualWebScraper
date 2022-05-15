using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebScraper.Application.Models;
using WebScraper.Data.Data;
using WebScraper.Data.Models;
using AutoMapper;

namespace WebScraper.Application.Services
{
    public class SearchHistoryService : ISearchHistoryService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public SearchHistoryService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<List<SearchHistoryResult>> GetSearchHistory()
        {
            var result = await _dataContext.SearchHistories.ToListAsync();
            var searchHistoryResults = _mapper.Map<List<SearchHistory>, List<SearchHistoryResult>>(result);

            return searchHistoryResults;
        }

        public async Task<SearchHistoryResult> InsertIntoSearchHistory(string searchEngineUsed, string keywords, string searchedFor, string positions)
        {
            EntityEntry<SearchHistory> searchHistoryEntry = _dataContext.SearchHistories.Add(new SearchHistory
            {
                SearchEngineUsed = searchEngineUsed,
                Keywords = keywords,
                SearchedFor = searchedFor,
                Positions = positions,
                Date = DateTime.Now,
            });
            _dataContext.SaveChanges();

            SearchHistoryResult searchHistoryResult = _mapper.Map<SearchHistory, SearchHistoryResult>(searchHistoryEntry.Entity);

            return searchHistoryResult;
        }
    }
}
