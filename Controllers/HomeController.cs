using Microsoft.AspNetCore.Mvc;

namespace razor_fun
{

    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

    }
}