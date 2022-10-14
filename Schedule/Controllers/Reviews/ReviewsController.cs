using AutoMapper;
using Command.Reviews.CreateNewReview;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TYPO.Controllers.Reviews
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public ReviewsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewReviewToText([FromBody] CreateNewReviewCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
