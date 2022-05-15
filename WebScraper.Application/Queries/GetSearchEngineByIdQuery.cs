using MediatR;
using WebScraper.Application.Models;

namespace WebScraper.Application.Queries
{
    public record GetSearchEngineByIdQuery(int SearchEngineId) : IRequest<SearchEngineResult>;
}
