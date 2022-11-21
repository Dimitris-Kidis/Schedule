using ApplicationCore.Domain.Entities;
using AutoMapper;

namespace Query.Texts.GetTextsPaged
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Text, PagedTextsDto>();

            CreateMap<IEnumerable<Text>, IEnumerable<PagedTextsDto>>();
        }
    }
}
