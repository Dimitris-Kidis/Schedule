using ApplicationCore.Domain.Entities;
using AutoMapper;

namespace Query.Reviews.GetAllReviews
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Review, ReviewDto>();
            CreateMap<IEnumerable<Review>, IEnumerable<ReviewDto>>();
        }
    }
}
