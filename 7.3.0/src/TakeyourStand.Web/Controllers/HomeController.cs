using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TakeyourStand.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TakeyourStandControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}