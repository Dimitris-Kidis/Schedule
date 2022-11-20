using ApplicationCore.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace Query.Reviews.GetReviewsPaged
{
 
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<PagedReviewsDto, GetPagedReviewsDto>();

            CreateMap<IEnumerable<PagedReviewsDto>, IEnumerable<GetPagedReviewsDto>>();

        }
    }
}
