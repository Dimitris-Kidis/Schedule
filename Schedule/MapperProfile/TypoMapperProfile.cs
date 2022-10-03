using ApplicationCore.Domain.Entities;
using AutoMapper;
using Query.ViewModels;
using TYPO.ApplicationCore.Domain.Entities;

namespace TYPO.MapperProfile
{
    public class TypoMapperProfile : Profile
    {
        public TypoMapperProfile()
        {
            this.CreateMap<User, AllUsersForAdminViewModel>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));
            //this.CreateMap<Exercise, ExerciseViewModel>()
            //    .ForMember(u => u.TrainingName, opt => opt.MapFrom(x => x.Training.Type));
            //this.CreateMap<FitnessTip, FitnessTipViewModel>()
            //    .ForMember(u => u.FitnessProgramName, opt => opt.MapFrom(x => x.FitnessProgram.FitnessType.Name));
            //this.CreateMap<Training, TrainingViewModel>()
            //    .ForMember(u => u.FitnessProgramName, opt => opt.MapFrom(x => x.FitnessProgram.FitnessType.Name));
            //this.CreateMap<FitnessType, FitnessTypeViewModel>()
            //    .ForMember(x => x.Id, y => y.MapFrom(z => z.FitnessProgramId));

            //this.CreateMap<Person, PersonDataDto>()
            //    .ForMember(u => u.FitnessLevel, opt => opt.MapFrom(x => x.FitnessLevel.ToString()))
            //    .ForMember(u => u.Gender, opt => opt.MapFrom(x => x.Gender.ToString()));

            //CreateMap<UserForRegistrationDto, Person>()
            //    .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email))
            //    .ForMember(u => u.BirthdayDate, opt => opt.MapFrom(x => x.Birthdate));
        }

    }
}
