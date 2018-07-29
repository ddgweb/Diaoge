using Microsoft.AspNetCore.Mvc;

namespace Diaoge.Web.Controllers
{
    public class HomeController : DiaogeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}