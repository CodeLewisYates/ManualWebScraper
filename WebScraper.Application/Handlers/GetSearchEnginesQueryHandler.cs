using MediatR;
using WebScraper.Application.Models;
using WebScraper.Application.Queries;
using WebScraper.Application.Services;

namespace WebScraper.Application.Handlers
{
    public class GetSearchEnginesQueryHandler : IRequestHandler<GetSearchEnginesQuery, List<SearchEngineResult>>
    {
        private readonly ISearchEngineService _searchEngineService;
        public GetSearchEnginesQueryHandler(ISearchEngineService searchEngineService)
        {
            _searchEngineService = searchEngineService;
        }

        public async Task<List<SearchEngineResult>> Handle(GetSearchEnginesQuery request, CancellationToken cancellationToken)
        {
            var result = await _searchEngineService.GetAllSearchEngines();
            return result;
        }
    }
}
