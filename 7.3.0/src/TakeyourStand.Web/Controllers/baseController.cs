using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TakeyourStand.Web.Controllers
{
    public class baseController : TakeyourStandControllerBase
    {
        public ActionResult home()
        {
            return View();
        }
        
        public ActionResult planandprice()
        {
            return View();
        } 
        
        public ActionResult clients()
        {
            return View();
        }
        
        public ActionResult products()
        {
            return View();
        }  
        
        public ActionResult contactus()
        {
            return View();
        }
	}
}