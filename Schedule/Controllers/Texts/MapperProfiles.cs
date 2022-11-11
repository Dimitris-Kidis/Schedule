using AutoMapper;
using Query.Texts.GetRandomTextByLanguage;
using Query.Texts.GetTextById;
using TYPO.Controllers.Texts.ViewModels;

namespace TYPO.Controllers.Texts
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<TextDto, GetTextByLanguageViewModel>();

            CreateMap<GetTextByIdDto, TextByIdViewModel>();
        }
    }
}
