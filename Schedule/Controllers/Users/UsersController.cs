using AutoMapper;
using Command.Users.CreateNewUser;
using Command.Users.DeleteUserById;
using HT3.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Users.GetAllUsers;
using Query.Users.GetInfoForDashboard;
using TYPO.Controllers.Users.ViewModels;

namespace TYPO.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UsersController( IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("AllUsers")]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);
            return Ok(result.Select(_mapper.Map<IEnumerable<AllUsersForAdminViewModel>>));
            //    users.Select(_mapper.Map<UserDto>);
            //return Ok(_mapper.Map<IEnumerable<AllUsersForAdminViewModel>>(result));
        }

        [HttpGet("Dashboard")]
        public async Task<IActionResult> GetPersonDashboardInfoById(int id)
        {
            var result = await _mediator.Send(new GetInfoForDashboardQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(_mapper.Map<GetInfoForDashboardViewModel>(result));
        }

        [HttpGet("ChartData")]
        public async Task<IActionResult> GetPersonChartDataById(int id)
        {
            var result = await _mediator.Send(new GetInfoForDashboardQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(_mapper.Map<GetInfoForDashboardViewModel>(result));
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewText([FromBody] CreateNewUserCommand command) // ВОПРОС command or viewmodel
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            var result = await _mediator.Send(new DeleteUserByIdCommand { Id = id });
            return Ok(result);
        }


    }
}
