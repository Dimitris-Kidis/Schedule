using AutoMapper;
using Command.StatisticsAVG.UpdateAverageStatistics;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Query.StatisticsAVG.GetAverageDataById;
using TYPO.Controllers.StatisticsAVG.ViewModels;

namespace TYPO.Controllers.StatisticsAVG
{
    [Authorize]
    [Route("api/average-statistics")]
    [ApiController]
    public class StatisticsAVGController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public StatisticsAVGController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet("stats-avg-{id}")]
        public async Task<IActionResult> GetStatsAvgById(int id)
        {
            var result = await _mediator.Send(new GetAverageDataByIdQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(_mapper.Map<StatisticsAVGViewModel>(result));
        }

        [AllowAnonymous]
        [HttpPut("stats-avg")]
        public async Task<IActionResult> UpdateStatsAvg([FromBody] UpdateAverageStatisticsCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == -1) return NotFound("There's no Average Statistic Line with this Id");
            return NoContent();
        }
    }
}
