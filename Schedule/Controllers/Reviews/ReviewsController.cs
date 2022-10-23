using AutoMapper;
using Command.Reviews.CreateNewReview;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Reviews.GetAllReviews;
using TYPO.Controllers.Reviews.ViewModels;

namespace TYPO.Controllers.Reviews
{
    [Route("api/reviews")]
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

        [HttpGet("all-reviews")]
        public async Task<IActionResult> GetAllReviews()
        {
            var query = new GetAllReviewsQuery();
            var result = await _mediator.Send(query);

            return Ok(result.Select(_mapper.Map<ReviewViewModel>));
        }
    }
}
