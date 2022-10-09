using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Texts.GetRandomTextByLanguage
{
    public class GetRandomTextByLanguageQuery : IRequest<TextDto>
    {
        public string Language { get; set; }
    }
}
