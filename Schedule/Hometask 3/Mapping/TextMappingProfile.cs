using HT3.Dtos;
using ApplicationCore.Domain.Entities;
using AutoMapper;
using TYPO.Hometask_3.Dtos;

namespace HT3.Mappings
{
    public class TextMappingProfile : Profile
    {
        public TextMappingProfile()
        {
            CreateMap<Text, TextDto>();
        }
    }
}
