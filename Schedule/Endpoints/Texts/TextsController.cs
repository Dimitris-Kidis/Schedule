using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Queries;
using Query.ViewModels;

namespace TYPO.Endpoints.Texts
{
    [Route("api/texts")]
    [ApiController]
    public class TextsController : ControllerBase
    {
        private readonly IMediator mediator;
        public TextsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("endpointTest")]
        public ActionResult<List<AllUsersForAdminViewModel>> GetAll()
        {
            Task<List<AllUsersForAdminViewModel>> result = this.mediator.Send(new GetInfoAboutAllUsersQuery());
            return result.Result;
        }
    }
}
