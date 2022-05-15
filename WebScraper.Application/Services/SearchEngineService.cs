using Microsoft.EntityFrameworkCore;
using WebScraper.Application.Models;
using WebScraper.Data.Data;
using WebScraper.Data.Models;
using AutoMapper;

namespace WebScraper.Application.Services
{
    public class SearchEngineService : ISearchEngineService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public SearchEngineService(DataContext context, IMapper mapper)
        {
            _dataContext = context;
            _mapper = mapper;
        }

        // returns specific search engine based on id from database
        public async Task<SearchEngineResult> GetSearchEngineById(int searchEngineId)
        {
            var result = await _dataContext.SearchEngines.Where(x => x.Id == searchEngineId).FirstOrDefaultAsync();
            if (result == null) return new SearchEngineResult();

            return new SearchEngineResult
            {
                Id = result.Id,
                BaseUrl = result.BaseUrl,
                Name = result.Name,
                Regex = result.Regex,
                SearchUrl = result.SearchUrl,
            };
        }

        // Returns all search engines from database
        public async Task<List<SearchEngineResult>> GetAllSearchEngines()
        {
            var result = await _dataContext.SearchEngines.ToListAsync();
            var searchEngines = _mapper.Map<List<SearchEngine>, List<SearchEngineResult>>(result);
            return searchEngines;
        }
    }
}
