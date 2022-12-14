using AutoMapper;
using Command.Users.CreateNewUser;
using Command.Users.DeleteUserById;
using Command.Users.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Query.Statistics.GetChartData;
using Query.Users.GetAllUsers;
using Query.Users.GetInfoForDashboard;
using Query.Users.GetUsersAndStatsAvgPaged;
using Query.Users.GetUsersPaged;
using TYPO.Controllers.Users.ViewModels;


namespace TYPO.Controllers.Users
{
    [Authorize]
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UsersController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("all-users")]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);
            result = result.OrderBy(prop => prop.Id);

            return Ok(result.Select(_mapper.Map<AllUsersForAdminViewModel>));
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPersonDashboardInfoById(int id)
        {
            var result = await _mediator.Send(new GetInfoForDashboardQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(_mapper.Map<GetInfoForDashboardViewModel>(result));
        }

        [HttpGet("chart-data/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPersonChartDataById(int id) 
        {
            var result = await _mediator.Send(new GetChartDataQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(result.Select(_mapper.Map<ChartDataViewModel>));
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateNewUser([FromBody] CreateNewUserCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == -1) return BadRequest("There's a user with such email");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            var result = await _mediator.Send(new DeleteUserByIdCommand { Id = id });
            if (result == -1) return NotFound("There's no user with such Id");
            return Ok(result);
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == -1) return NotFound("There's no user with such id");
            return NoContent();
        }

        [HttpPost("paginated")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPagedUsers(GetPagedUsersQuery query)
        {
            var pagedUsersDto = await _mediator.Send(query);
            return Ok(pagedUsersDto);
        }

        [HttpPost("paginated-users-average")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPagedUsersAvg(GetUsersAndStatsAvgPagedQuery query)
        {
            var pagedUsersDto = await _mediator.Send(query);
            return Ok(pagedUsersDto);
        }
    }
}
