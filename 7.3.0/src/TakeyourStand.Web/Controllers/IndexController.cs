using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TakeyourStand.Web.Controllers
{
    public class IndexController : TakeyourStandControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}