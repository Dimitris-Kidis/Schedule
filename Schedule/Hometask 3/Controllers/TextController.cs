using System;
using System.Collections.Generic;
using System.Linq;
using HT3.Dtos;
using HT3.Exceptions;
using HT3.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TYPO.Hometask_3.Dtos;


namespace HT3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITextService _textService;

        public TextController(ITextService textService, IMapper mapper)
        {
            _textService = textService;
            _mapper = mapper;
        }

        [HttpGet]
        [ApiExceptionFilter]
        public IActionResult Get()
        {
            var query = HttpContext.Request.Query;

            var texts = _textService.GetAllTexts();
            var result = texts.Select(e => _mapper.Map<TextDto>(e));

            return Ok(result);
        }

        [HttpPost]
        [ApiExceptionFilter]
        public IActionResult Post([FromBody] CreateTextDto dto)
        {
            var text = _textService.AddNewText(dto);

            if (text == null)
                return BadRequest("Text with such Id already exists");

            return CreatedAtAction(nameof(Get), new { id = text.Id }, text);
        }

        [HttpPut("{id}")]
        [ApiExceptionFilter]
        public IActionResult Put(int id, [FromBody] UpdateTextDto dto)
        {
            var text = _textService.UpdateTextById(id, dto);

            if (text == null)
                return BadRequest("There's a text with such id already exists");

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ApiExceptionFilter]
        public IActionResult Patch(int id, [FromBody] UpdateTextContentDto dto)
        {
            var text = _textService.UpdateTextContentById(id, dto);

            if (text == null)
                return NotFound();

            var result = _mapper.Map<TextDto>(text);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        [ApiExceptionFilter]
        public IActionResult Delete(int id)
        {
            var isDeleted = _textService.RemoveTextById(id);

            return NoContent();
        }
    }
}
