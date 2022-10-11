using AutoMapper;
using Command.UsersInfo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TYPO.Controllers.UsersInfo
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersInfoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UsersInfoController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> CreateUserInfo([FromBody] CreateUserInfoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
