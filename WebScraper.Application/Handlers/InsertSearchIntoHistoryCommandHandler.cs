using MediatR;
using WebScraper.Application.Models;
using WebScraper.Application.Commands;
using WebScraper.Application.Services;

namespace WebScraper.Application.Handlers
{
    public class InsertSearchIntoHistoryCommandHandler : IRequestHandler<InsertSearchIntoHistoryCommand, SearchHistoryResult>
    {
        private readonly ISearchHistoryService _searchHistoryService;
        public InsertSearchIntoHistoryCommandHandler(ISearchHistoryService searchHistoryService)
        {
            _searchHistoryService = searchHistoryService;
        }
        public async Task<SearchHistoryResult> Handle(InsertSearchIntoHistoryCommand request, CancellationToken cancellationToken)
        {
            var result = await _searchHistoryService.InsertIntoSearchHistory(request.SearchEngineUsed, request.Keywords, request.SearchedFor, request.Positions);
            return result;
        }
    }
}
