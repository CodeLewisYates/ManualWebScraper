using MediatR;
using WebScraper.Application.Commands;
using WebScraper.Application.Models;
using WebScraper.Application.Queries;
using WebScraper.Application.Services;

namespace WebScraper.Application.Handlers
{
    public class GetSearchPositionsQueryHandler : IRequestHandler<GetSearchPositionsQuery, SearchPositionsResult>
    {
        private readonly ISearchPositionsService _searchPositionsService;
        private readonly IMediator _mediator;
        public GetSearchPositionsQueryHandler(ISearchPositionsService searchPositionsService, IMediator mediator)
        {
            _searchPositionsService =  searchPositionsService;
            _mediator = mediator;
        }

        public async Task<SearchPositionsResult> Handle(GetSearchPositionsQuery request, CancellationToken cancellationToken)
        {
            var searchEngine = await _mediator.Send(new GetSearchEngineByIdQuery(request.SearchEngineId), cancellationToken);
            if (searchEngine.Id == 0) return new SearchPositionsResult { Positions = "0" };

            SearchPositionsResult result = await _searchPositionsService.GetSearchPositions(searchEngine.BaseUrl, searchEngine.SearchUrl, searchEngine.Regex, request.Keywords, request.SearchFor);

            await _mediator.Send(new InsertSearchIntoHistoryCommand(searchEngine.Name, request.Keywords, request.SearchFor, result.Positions), cancellationToken);

            return result;
        }
    }
}
