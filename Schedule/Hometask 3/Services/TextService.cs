using HT3.Dtos;
using HT3.Exceptions;
using HT3.Repositories;
using ApplicationCore.Domain.Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using TYPO.Hometask_3.Dtos;

namespace HT3.Services
{
    public class TextService : ITextService
    {
        private readonly IRepo<Text> _textRepository;

        public TextService(IRepo<Text> textRepository)
        {
            _textRepository = textRepository;
        }

        public Text AddNewText(CreateTextDto createTextDto)
        {
            var text = new Text
            {
                TextContent = createTextDto.TextContent,
                Author = createTextDto.Author,
                Level = createTextDto.Level,
                CreatedBy = "User-1",
                CreatedAt = DateTimeOffset.Now
            };

            _textRepository.Add(text);
            _textRepository.Save();
            return text;
        }
        public IList<Text> GetAllTexts()
        {
            return _textRepository.GetAll().ToList();
        }

        public Text UpdateTextContentById(int id, UpdateTextContentDto dto)
        {
            Text text = _textRepository.Find(id);

            if (text == null)
            {
                throw new NotFoundException("Text not found!");
            }

            text.TextContent = dto.TextContent;
            _textRepository.Save();
            return text;
        }

        public Text UpdateTextById(int id, UpdateTextDto dto)
        {
            Text text = _textRepository.Find(id);

            if (text == null)
            {
                throw new NotFoundException("Text not found!");
            }

            text.Author = dto.Author;
            text.Level = dto.Level;
            text.TextContent = dto.TextContent;
            _textRepository.Save();
            return text;
        }

        public bool RemoveTextById(int id)
        {
            var text = _textRepository.Find(id);
            if (text != null)
            {
                _textRepository.Delete(text);
                _textRepository.Save();
                return true;
            }
            else return false;
        }
    }
}
