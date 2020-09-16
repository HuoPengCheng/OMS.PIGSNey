using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using OMS.PIGSNey.Controllers;

namespace OMS.PIGSNey.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PIGSNeyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
