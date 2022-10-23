using AutoMapper;
using Command.Texts.CreateNewText;
using Command.Texts.DeleteTextById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Texts.GetRandomTextByLanguage;
using TYPO.Controllers.Texts.ViewModels;

namespace TYPO.Controllers.Texts
{
    [Route("api/texts")]
    [ApiController]
    public class TextsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public TextsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTextByLanguage([FromQuery] string language)
        {
            var result = await _mediator.Send(new GetRandomTextByLanguageQuery { Language = language });
            if (result == null)
            {
                return BadRequest("Text not found");
            }
            return Ok(_mapper.Map<GetTextByLanguageViewModel>(result));
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewText([FromBody] CreateNewTextCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTextById(int id)
        {
            var result = await _mediator.Send(new DeleteTextByIdCommand { Id = id });
            if (result == -1) return NotFound("There's no text with such Id");
            return Ok(result);
        }


    }

}
