using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhuocProjectTest.MultiTenancy.Dto;

namespace PhuocProjectTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
