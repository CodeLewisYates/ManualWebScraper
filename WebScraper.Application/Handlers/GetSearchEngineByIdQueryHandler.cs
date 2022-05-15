using MediatR;
using WebScraper.Application.Queries;
using WebScraper.Application.Models;
using WebScraper.Application.Services;

namespace WebScraper.Application.Handlers
{
    public class GetSearchEngineByIdQueryHandler : IRequestHandler<GetSearchEngineByIdQuery, SearchEngineResult>
    {
        private readonly ISearchEngineService _searchEngineService;
        public GetSearchEngineByIdQueryHandler(ISearchEngineService searchEngineService)
        {
            _searchEngineService = searchEngineService;
        }
        public async Task<SearchEngineResult> Handle(GetSearchEngineByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _searchEngineService.GetSearchEngineById(request.SearchEngineId);
            return result;
        }
    }
}
