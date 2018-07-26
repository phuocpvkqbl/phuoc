using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PhuocProjectTest.Controllers;

namespace PhuocProjectTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PhuocProjectTestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
