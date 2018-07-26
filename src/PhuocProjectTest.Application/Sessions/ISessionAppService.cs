using System.Threading.Tasks;
using Abp.Application.Services;
using PhuocProjectTest.Sessions.Dto;

namespace PhuocProjectTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
