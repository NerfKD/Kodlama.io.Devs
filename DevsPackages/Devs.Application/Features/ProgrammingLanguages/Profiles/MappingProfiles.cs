using AutoMapper;
using Core.Persistence.Paging;
using Devs.Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using Devs.Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage;
using Devs.Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
using Devs.Application.Features.ProgrammingLanguages.Dtos;
using Devs.Application.Features.ProgrammingLanguages.Models;
using Devs.Domain.Entities;

namespace Devs.Application.Features.ProgrammingLanguages.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ProgrammingLanguage, CreatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommand>().ReverseMap();
            CreateMap<ProgrammingLanguage, UpdatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommand>().ReverseMap();
            CreateMap<ProgrammingLanguage, DeletedProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, DeleteProgrammingLanguageCommand>().ReverseMap();
            CreateMap<IPaginate<ProgrammingLanguage>, ProgrammingLanguageListModel>().ReverseMap();
            CreateMap<ProgrammingLanguage, ProgrammingLanguageGetListDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, ProgrammingLanguageGetByIdDto>().ReverseMap();
        }
    }
}
