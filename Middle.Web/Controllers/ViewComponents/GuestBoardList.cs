using Microsoft.AspNetCore.Mvc;
using Middle.Services.Intferfaces;

namespace Middle.Web.Controllers.ViewComponents
{
    public class GuestBoardList : ViewComponent
    {
        private readonly IGuestBoard _guestBoard;

        public GuestBoardList(IGuestBoard guestBoard)
        {
            _guestBoard = guestBoard;
        }

        public IViewComponentResult Invoke()
        {
            var guestBoards = _guestBoard.GetAllGuestBoards();
            return View(guestBoards);
        }
    }
}
