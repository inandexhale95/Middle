using Microsoft.AspNetCore.Mvc;
using Middle.Data.DataModels;
using Middle.Services.Intferfaces;

namespace Middle.Web.Controllers
{
    // 여기는 메인 컨트롤
    public class HomeController : Controller
    {
        private readonly IUser _user;

        public HomeController(IUser user)
        {
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 로그인 모달
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {

            }
            return RedirectToAction("Index", "Home");
        }
        
        /// <summary>
        /// 회원가입 페이지 뷰
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                _user.RegisterUser(model);
                if (_user.Save() > 0)
                {
                    TempData["Result"] = "회원가입에 성공했습니다!";
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError(string.Empty, "회원가입에 실패했습니다.");
            return View(model);
        }
    }
}
