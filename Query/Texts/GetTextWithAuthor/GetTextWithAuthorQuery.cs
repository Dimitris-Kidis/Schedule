using MediatR;
using Query.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.Texts.GetTextWithAuthor
{
    public class GetTextWithAuthorQuery : IRequest<TextAuthorViewModel>
    {
    }
}
