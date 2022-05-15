using MediatR;
using WebScraper.Application.Models;

namespace WebScraper.Application.Queries
{
    public record GetSearchHistoryQuery() : IRequest<List<SearchHistoryResult>>;
}
