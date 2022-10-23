using ApplicationCore.Pagination.PagedReq;
using AutoMapper;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Command.Blobs.UploadAvatar;
using Command.Blobs.UploadPersonalAvatar;
using Command.Users.CreateNewUser;
using Command.Users.DeleteUserById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Query.Statistics.GetChartData;
using Query.Users.GetAllUsers;
using Query.Users.GetInfoForDashboard;
using Query.Users.GetUsersPaged;
using TYPO.Controllers.Users.ViewModels;


namespace TYPO.Controllers.Users
{
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
        public async Task<IActionResult> Get()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);
            result = result.OrderBy(prop => prop.Id);

            return Ok(result.Select(_mapper.Map<AllUsersForAdminViewModel>));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonDashboardInfoById(int id) // Убрать айди и убрать проперти в квери
        {
            var result = await _mediator.Send(new GetInfoForDashboardQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(_mapper.Map<GetInfoForDashboardViewModel>(result));
        }

        [HttpGet("chart-data/{id}")]
        public async Task<IActionResult> GetPersonChartDataById(int id) 
        {
            var result = await _mediator.Send(new GetChartDataQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            //return Ok(_mapper.Map<ChartDataViewModel>(result));
            return Ok(result.Select(_mapper.Map<ChartDataViewModel>));
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewUser([FromBody] CreateNewUserCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == -1) return BadRequest("There's a user with such email");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserById(int id) //  тут оставляем для админа
        {
            var result = await _mediator.Send(new DeleteUserByIdCommand { Id = id });
            if (result == -1) return NotFound("There's no user with such Id");
            return Ok(result);
        }
        
        [HttpPost("upload-avatar-id")]
        public async Task<IActionResult> UploadAvatar([FromForm] UploadAvatarCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("upload-personal-avatar")]
        public async Task<IActionResult> UploadPersonalAvatar([FromForm] UploadPersonalAvatarCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("paginated-search")]
        public async Task<IActionResult> GetPagedBooks(GetPagedUsersQuery query)
        {
            var pagedBooksDto = await _mediator.Send(query);
            return Ok(pagedBooksDto);
        }
    }
}
