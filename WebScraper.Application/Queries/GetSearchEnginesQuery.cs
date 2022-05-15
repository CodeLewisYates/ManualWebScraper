using MediatR;
using WebScraper.Application.Models;

namespace WebScraper.Application.Queries
{
    public record GetSearchEnginesQuery() : IRequest<List<SearchEngineResult>>;
}
