using Microsoft.AspNetCore.Mvc;
using Middle.Data.DataModels;
using Middle.Services.Intferfaces;

namespace Middle.Web.Controllers
{
    public class GuestBoardController : Controller
    {
        public readonly IGuestBoard _guestBoard;
        public GuestBoardController(IGuestBoard guestBoard)
        {
            _guestBoard = guestBoard;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(GuestBoard model)
        {
            if (ModelState.IsValid)
            {
                _guestBoard.AddGuestBoard(model);
                if (_guestBoard.Save() > 0)
                    return Redirect("Index");
            }
            // 
            ModelState.AddModelError(string.Empty, "등록에 실패했습니다.");
            return View("Index", model);
        }
    }
}
