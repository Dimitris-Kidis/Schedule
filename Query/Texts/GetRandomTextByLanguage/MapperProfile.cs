using ApplicationCore.Domain.Entities;
using AutoMapper;

namespace Query.Texts.GetRandomTextByLanguage
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Text, TextDto>();
        }
    }

}
