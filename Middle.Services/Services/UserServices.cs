using Middle.Data.DataModels;
using Middle.Services.Context;
using Middle.Services.Intferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middle.Services.Services
{
    public class UserServices : IUser
    {
        public readonly AppDbContext _context;
        public UserServices(AppDbContext context)
        {
            _context = context;
        }

        public void RegisterUser(User user)
        {
            if (user == null) throw new ArgumentNullException("user is null");
            _context.Users.Add(user);
        }
        public User LoginUser(User user)
        {
            if (user == null) throw new ArgumentNullException("user is null");
            return _context.Users.
                FirstOrDefault(u => u.UserId.Equals(user.UserId) && u.UserPassword.Equals(user.UserPassword));
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
