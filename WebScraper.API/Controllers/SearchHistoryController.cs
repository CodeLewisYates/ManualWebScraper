using Microsoft.AspNetCore.Mvc;
using WebScraper.Application.Queries;
using MediatR;

namespace WebScraper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchHistoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SearchHistoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/searchHistory
        [HttpGet]
        public async Task<IActionResult> GetSearchHistory()
        {
            var result = await _mediator.Send(new GetSearchHistoryQuery());
            return Ok(result);
        }

    }
}
