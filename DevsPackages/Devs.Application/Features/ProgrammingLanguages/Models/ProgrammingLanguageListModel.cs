using Core.Persistence.Paging;
using Devs.Application.Features.ProgrammingLanguages.Dtos;

namespace Devs.Application.Features.ProgrammingLanguages.Models
{
    public class ProgrammingLanguageListModel : BasePageableModel
    {
        public IList<ProgrammingLanguageGetListDto> Items { get; set; }
    }
}
