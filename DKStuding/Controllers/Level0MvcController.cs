using Microsoft.AspNetCore.Mvc;

namespace DKStuding.Controllers
{
    public class Level0MvcController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            string model = "Index page";
            return View(model);
        }

        [HttpGet]
        public ActionResult Hello(string name)
        {
            string model = "Hello " + name + "!";
            return View(model);
        }
    }
}
