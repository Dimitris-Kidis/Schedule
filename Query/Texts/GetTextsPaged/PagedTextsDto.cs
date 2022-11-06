﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Texts.GetTextsPaged
{
    public class PagedTextsDto
    {
        public int Id { get; set; }
        public string TextContent { get; set; }
        public string Author { get; set; }
        public int Level { get; set; }
        public string Language { get; set; }
    }
}
