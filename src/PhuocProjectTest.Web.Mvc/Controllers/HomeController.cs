using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PhuocProjectTest.Controllers;

namespace PhuocProjectTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhuocProjectTestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
