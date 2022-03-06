using Middle.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Middle.Services.Intferfaces
{
    public interface IGuestBoard
    {
        List<GuestBoard> GetAllGuestBoards();
        void AddGuestBoard(GuestBoard guestBoard);
        int Save(); 
    }
}
