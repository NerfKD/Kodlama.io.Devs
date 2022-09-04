using Core.Persistence.Repositories;
using Devs.Domain.Entities;

namespace Devs.Application.Services.Repositories
{
    public interface IProgrammingLanguageRepository : IAsyncRepository<ProgrammingLanguage>, IRepository<ProgrammingLanguage>
    {
    }
}
