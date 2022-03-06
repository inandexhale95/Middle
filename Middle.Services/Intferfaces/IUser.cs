using Middle.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Middle.Services.Intferfaces
{
    public interface IUser
    {
        void RegisterUser(User user);
        User LoginUser(User user);
        int Save();
    }
}
