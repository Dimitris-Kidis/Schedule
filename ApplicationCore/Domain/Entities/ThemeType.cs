using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

namespace ApplicationCore.Domain.Entities
{
    public class ThemeType : BaseEntity
    {
        public string MainColor { get; set; }
        public string SecondColor { get; set; }

    }
}
