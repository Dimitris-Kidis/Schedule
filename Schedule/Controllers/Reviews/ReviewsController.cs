using AutoMapper;
using Command.Reviews.CreateNewReview;
using Command.Reviews.DeleteReview;
using Command.Reviews.UpdateReview;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Query.Reviews.GetAllReviews;
using Query.Reviews.GetReviewById;
using Query.Reviews.GetReviewsPaged;
using TYPO.Controllers.Reviews.ViewModels;

namespace TYPO.Controllers.Reviews
{
    [Authorize]
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

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateNewReviewToText([FromBody] CreateNewReviewCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("all-reviews")]
        public async Task<IActionResult> GetAllReviews()
        {
            var query = new GetAllReviewsQuery();
            var result = await _mediator.Send(query);

            return Ok(result.Select(_mapper.Map<ReviewViewModel>));
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReviewById(int id)
        {
            var result = await _mediator.Send(new GetReviewByIdQuery { Id = id });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(_mapper.Map<ReviewByIdViewModel>(result));
        }

        [AllowAnonymous]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReviewById(int id)
        {
            var result = await _mediator.Send(new DeleteReviewByIdCommand { Id = id });
            if (result == -1) return NotFound("There's no review with such id");
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPut]
        public async Task<IActionResult> UpdateReview([FromBody] UpdateReviewCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == -1) return NotFound("There's no review with such id");
            return NoContent();
        }

        [AllowAnonymous]
        [HttpPost("paginated")]
        public async Task<IActionResult> GetPagedReviews(GetPagedReviewsQuery query)
        {
            var pagedReviewsDto = await _mediator.Send(query);
            return Ok(pagedReviewsDto);
        }
    }
}
