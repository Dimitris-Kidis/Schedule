using ApplicationCore.Domain.Entities;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
