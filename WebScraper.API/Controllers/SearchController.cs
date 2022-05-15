using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebScraper.API.Dtos;
using WebScraper.Application.Queries;

namespace WebScraper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SearchController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // post api/search
        [HttpPost]
        public async Task<IActionResult> GetSearchPositions([FromBody] SearchPositionsDto dto)
        {
            var result = await _mediator.Send(new GetSearchPositionsQuery(dto.SearchEngineId, dto.Keywords, dto.SearchFor));
            return Ok(result);
        }
    }
}
