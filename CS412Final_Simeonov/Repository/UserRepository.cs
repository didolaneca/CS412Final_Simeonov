using CS412Final_Simeonov.DAL;
using CS412Final_Simeonov.Models;
using CS412Final_Simeonov.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Repository
{
    public class UserRepository : IUserRepository
    {
        public User getUserDetails(string username, string password)
        {
            return UserDAL.GetUser(username, password);
        }

        public bool saveUser(User user)
        {
            UserDAL.SaveUser(user);
            return true;
        }
    }
}