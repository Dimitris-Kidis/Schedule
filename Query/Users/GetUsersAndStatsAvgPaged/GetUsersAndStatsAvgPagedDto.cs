﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Users.GetUsersAndStatsAvgPaged
{
    public class GetUsersAndStatsAvgPagedDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float AvgSymbolsPerMin { get; set; }
        public float AvgAccuracy { get; set; }
        public string AvgTime { get; set; }
    }
}