using Microsoft.AspNetCore.Mvc;

namespace Middle.Web.Controllers
{
    // 여기는 방명록 컨트롤
    public class BoardController : Controller
    {
        public IActionResult Index()
        {
            // 로그인이 안되어 있을 경우 Redirect
            if (false)
            {

                return RedirectToAction("Login", "Home");
            }

            return View();
        }
    }
}
