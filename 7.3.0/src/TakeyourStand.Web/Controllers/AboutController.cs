using System.Web.Mvc;

namespace TakeyourStand.Web.Controllers
{
    public class AboutController : TakeyourStandControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}