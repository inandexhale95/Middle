using Middle.Data.DataModels;
using Middle.Services.Context;
using Middle.Services.Intferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middle.Services.Services
{
    public class GuestBoardServices : IGuestBoard
    {
        public readonly AppDbContext _context;
        public GuestBoardServices(AppDbContext context)
        {
            _context = context;
        }
        public List<GuestBoard> GetAllGuestBoards()
        {
            return _context.GuestBoards
                .OrderByDescending(g => g.Id)
                .ToList();
        }
        public void AddGuestBoard(GuestBoard guestBoard)
        {
            if (guestBoard == null) throw new ArgumentNullException("model is null");
            _context.Add(guestBoard);
        }
        public int Save()
        {
            // 성공하면 1을 반환
            return _context.SaveChanges();
        }
    }
}
