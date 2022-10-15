using AutoMapper;
using Command.Users.CreateNewUser;
using Command.Users.DeleteUserById;
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

        [HttpGet("all-users")]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);

            return Ok(result.Select(_mapper.Map<AllUsersForAdminViewModel>));
        }

        [HttpGet("dashboard")]
        public async Task<IActionResult> GetPersonDashboardInfoById(int id)
        {
            var result = await _mediator.Send(new GetInfoForDashboardQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(_mapper.Map<GetInfoForDashboardViewModel>(result));
        }

        [HttpGet("chart-data")]
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
        public async Task<IActionResult> CreateNewUser([FromBody] CreateNewUserCommand command) 
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            var result = await _mediator.Send(new DeleteUserByIdCommand { Id = id });
            return Ok(result);
        }


    }
}
