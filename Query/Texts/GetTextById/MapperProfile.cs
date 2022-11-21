using ApplicationCore.Domain.Entities;
using AutoMapper;

namespace Query.Texts.GetTextById
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Text, GetTextByIdDto>();
        }
    }
}
