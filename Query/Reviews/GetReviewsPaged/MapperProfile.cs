using ApplicationCore.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Reviews.GetReviewsPaged
{
 
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Review, GetPagedReviewsDto>();

            CreateMap<IEnumerable<Review>, IEnumerable<GetPagedReviewsDto>>();

            CreateMap<PagedReviewsDto, GetPagedReviewsDto>();

        }
    }
}
