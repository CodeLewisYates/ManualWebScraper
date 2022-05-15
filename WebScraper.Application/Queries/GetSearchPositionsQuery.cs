using MediatR;
using WebScraper.Application.Models;

namespace WebScraper.Application.Queries
{
    public record GetSearchPositionsQuery(int SearchEngineId, string Keywords, string SearchFor) : IRequest<SearchPositionsResult>;
}
