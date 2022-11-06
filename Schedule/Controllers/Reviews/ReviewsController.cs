using AutoMapper;
using Command.Reviews.CreateNewReview;
using Command.Reviews.DeleteReview;
using Command.Reviews.UpdateReview;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Reviews.GetAllReviews;
using Query.Reviews.GetReviewsPaged;
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReviewById(int id)
        {
            var result = await _mediator.Send(new DeleteReviewByIdCommand { Id = id });
            if (result == -1) return NotFound("There's no review with such id");
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReview([FromBody] UpdateReviewCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == -1) return NotFound("There's no review with such id");
            return NoContent();
        }

        [HttpPost("paginated")]
        public async Task<IActionResult> GetPagedReviews(GetPagedReviewsQuery query)
        {
            var pagedReviewsDto = await _mediator.Send(query);
            return Ok(pagedReviewsDto);
        }
    }
}
