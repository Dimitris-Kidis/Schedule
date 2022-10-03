using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TYPO.ApplicationCore.Domain;

namespace TYPO.Middleware
{
    [Route("api/[controller]")]
    [ApiController]
    public class HandlerController : ControllerBase
    {
        private readonly TypoDbContext _context;
        public HandlerController(TypoDbContext context)
        {
            _context = context;

        }

        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Users.Find(30);
            if (thing == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok();
        }

        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            var thing = _context.Users.Find(17);
            var thingToReturn = thing.ToString();

            return Ok();
        }
    }
}
