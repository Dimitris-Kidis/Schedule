using HT3.Dtos;
using ApplicationCore.Domain.Entities;
using System.Collections.Generic;
using TYPO.Hometask_3.Dtos;

namespace HT3.Services
{
    public interface ITextService
    {
        IList<Text> GetAllTexts();
        Text AddNewText(CreateTextDto dto);
        Text UpdateTextContentById(int id, UpdateTextContentDto dto);
        Text UpdateTextById(int id, UpdateTextDto dto);
        bool RemoveTextById(int id);
    }
}
