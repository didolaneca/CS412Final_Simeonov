using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.DAL
{
    public static class UserDAL
    {
        static List<User> allUsers = Users.getAllUsers(); 
        
        //READ
        public static User GetUser(string email, string password) {
            return allUsers.Find(usr => {
                return usr.Email.Equals(email) && usr.Password.Equals(password);
            });
        }
        
        //DELETE - I don't think we should give ability to the user to delete their account
        public static Boolean DeleteUser(string email, string password)
        {

            User userToBeRemoved = GetUser(email, password);
            return allUsers.Remove(userToBeRemoved); 
        }

        //ADD
        public static void SaveUser(User user)
        {
            allUsers.Add(user);
        }

        //Update??? we can use the  saveuser to update?
        public static User UpdateUser(User user)
        {
            return new User();
        }
    }
}