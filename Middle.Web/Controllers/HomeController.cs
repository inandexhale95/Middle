using Microsoft.AspNetCore.Mvc;

namespace Middle.Web.Controllers
{
    // 여기는 메인 컨트롤
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginProcess()
        {

            return RedirectToAction("Index", "Home");
        }
        
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterProcess()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}
