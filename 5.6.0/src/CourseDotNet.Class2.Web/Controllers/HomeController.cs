using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CourseDotNet.Class2.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Class2ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}