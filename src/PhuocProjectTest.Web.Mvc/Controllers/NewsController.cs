using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using PhuocProjectTest.Authorization;
using PhuocProjectTest.Controllers;
using PhuocProjectTest.Users;
using PhuocProjectTest.Web.Models.Users;
using PhuocProjectTest.New;

namespace PhuocProjectTest.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class NewsController : PhuocProjectTestControllerBase
    {
        private readonly NewsAppService _newAppService;

        public NewsController(NewsAppService newAppService)
        {
            _newAppService = newAppService;
        }


        public async Task<ActionResult> Index()
        {
            var model = (await _newAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            return View(model);
        }

        //public async Task<ActionResult> EditUserModal(long userId)
        //{
        //    var user = await _userAppService.Get(new EntityDto<long>(userId));
        //    var roles = (await _userAppService.GetRoles()).Items;
        //    var model = new EditUserModalViewModel
        //    {
        //        User = user,
        //        Roles = roles
        //    };
        //    return View("_EditUserModal", model);
        //}
    }
}
