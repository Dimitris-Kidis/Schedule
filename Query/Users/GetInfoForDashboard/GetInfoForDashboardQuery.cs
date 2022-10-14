﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Users.GetInfoForDashboard
{
    public class GetInfoForDashboardQuery : IRequest<DashboardInfoDto> 
    {
        public int Id { get; set; }
    }
}
