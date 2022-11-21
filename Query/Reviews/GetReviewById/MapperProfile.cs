using ApplicationCore.Domain.Entities;
using AutoMapper;

namespace Query.Reviews.GetReviewById
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Review, GetReviewByIdDto>();
        }
    }
}
