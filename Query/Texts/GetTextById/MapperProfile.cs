using ApplicationCore.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
