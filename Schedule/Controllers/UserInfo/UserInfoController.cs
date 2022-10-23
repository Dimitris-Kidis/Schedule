using AutoMapper;
using Command.UserInfo.PartialUpdateLanguageById;
using Command.UserInfo.PartialUpdateThemeById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TYPO.Controllers.UserInfo
{

    [Route("api/user-info")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UserInfoController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPatch("language")]
        public async Task<IActionResult> UpdateLanguageById([FromBody] PartialUpdateUserInfoLanguageByIdCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == -1) return NotFound("There's no user with such Id");
            return NoContent();
        }

        [HttpPatch("theme")]
        public async Task<IActionResult> UpdateThemeById([FromBody] PartialUpdateUserInfoThemeByIdCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == -1) return NotFound("There's no user with such Id");
            return NoContent();
        }


    }
}
