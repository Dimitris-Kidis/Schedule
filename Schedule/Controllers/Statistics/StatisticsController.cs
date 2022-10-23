using AutoMapper;
using Command.Statistics.CreateNewStatisticLine;
using Command.Statistics.DeleteAllStatisticsById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Statistics.GetStatisticsById;
using TYPO.Controllers.Statistics.ViewModels;

namespace TYPO.Controllers.Statistics
{
    [Route("api/statistics")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public StatisticsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewStatisticLine([FromBody] CreateNewStatisticLineCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("statistics-list-{id}")]
        public async Task<IActionResult> GetStatisticsById(int id)
        {
            var result = await _mediator.Send(new GetStatisticsByIdQuery { Id = id });
            if (result.Count() == 0)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(result.Select(_mapper.Map<StatisticsViewModel>));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAllStatistics(int id)
        {
            var result = await _mediator.Send(new DeleteAllStatisticsByIdCommand { Id = id });
            if (result == -1) return NotFound("There's no such Id");
            return Ok(result);
        }

    }
}
