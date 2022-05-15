using MediatR;
using WebScraper.Application.Models;

namespace WebScraper.Application.Commands
{
    public record InsertSearchIntoHistoryCommand(string SearchEngineUsed, string Keywords, string SearchedFor, string Positions) : IRequest<SearchHistoryResult>;
}
