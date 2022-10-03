using AutoMapper;
using HT3.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Users.GetAllUsers;
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

        [HttpGet]
        [ApiExceptionFilter]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);

            return Ok(_mapper.Map<IEnumerable<AllUsersForAdminViewModel>>(result));
        }


    }
}
