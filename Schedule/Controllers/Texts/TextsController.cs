using AutoMapper;
using Command.Texts.CreateNewText;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Query.Texts.GetRandomTextByLanguage;
using TYPO.Controllers.Texts.ViewModels;

namespace TYPO.Controllers.Texts
{
    [Route("api/[controller]")]
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
        public async Task<IActionResult> GetTextByLanguage(string language)
        {
            var result = await _mediator.Send(new GetRandomTextByLanguageQuery { Language = language });
            if (result == null)
            {
                return BadRequest("Entity is not found");
            }
            return Ok(_mapper.Map<GetTextByLanguageViewModel>(result));
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewText([FromBody] CreateNewTextCommand command) // ВОПРОС про боди
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


    }

}
