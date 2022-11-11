using AutoMapper;
using Query.Reviews.GetAllReviews;
using Query.Reviews.GetReviewById;
using TYPO.Controllers.Reviews.ViewModels;

namespace TYPO.Controllers.Reviews
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<IEnumerable<ReviewDto>, IEnumerable<ReviewViewModel>>();

            CreateMap<ReviewDto, ReviewViewModel>();

            CreateMap<GetReviewByIdDto, ReviewByIdViewModel>();
        }
        
    }
}
