using CS412Final_Simeonov.BLL.Interfaces;
using CS412Final_Simeonov.DAL;
using CS412Final_Simeonov.Models;
using CS412Final_Simeonov.Repository;
using CS412Final_Simeonov.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.BLL
{
    public class UserBLL : IUserBLL
    {
        private readonly IUserRepository userRepository;
        public UserBLL()
        {
            this.userRepository = new UserRepository();
        }
        public User GetUserByUsernameAndPassword(string username, string password)
        {
            return userRepository.getUserDetails(username, password);
        }

        public User SaveUser(User user)
        {
            userRepository.saveUser(user);
            return user;
        }
    }
}