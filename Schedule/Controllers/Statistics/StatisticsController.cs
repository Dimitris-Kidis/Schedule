using AutoMapper;
using Command.Statistics.CreateNewStatisticLine;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TYPO.Controllers.Statistics
{
    [Route("api/[controller]")]
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
    }
}
