using ApplicationCore.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
