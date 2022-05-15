using MediatR;
using WebScraper.Application.Models;
using WebScraper.Application.Queries;
using WebScraper.Application.Services;

namespace WebScraper.Application.Handlers
{
    public class GetSearchHistoryQueryHandler : IRequestHandler<GetSearchHistoryQuery, List<SearchHistoryResult>>
    {
        private readonly ISearchHistoryService _searchHistoryService;
        public GetSearchHistoryQueryHandler(ISearchHistoryService searchHistoryService)
        {
            _searchHistoryService = searchHistoryService;
        }
        public async Task<List<SearchHistoryResult>> Handle(GetSearchHistoryQuery request, CancellationToken cancellationToken)
        {
            var result = await _searchHistoryService.GetSearchHistory();
            return result;
        }
    }
}
