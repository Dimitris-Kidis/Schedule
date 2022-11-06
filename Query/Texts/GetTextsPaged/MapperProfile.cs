﻿using ApplicationCore.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
