using Microsoft.AspNetCore.Mvc;
using MediatR;
using WebScraper.Application.Queries;

namespace WebScraper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchEngineController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SearchEngineController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/searchEngine
        [HttpGet]
        public async Task<IActionResult> GetSearchEngines()
        {
            var result = await _mediator.Send(new GetSearchEnginesQuery());
            return Ok(result);
        }
    }
}
