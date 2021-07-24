using CS412Final_Simeonov.Helpers;
using CS412Final_Simeonov.Models;
using CS412Final_Simeonov.Repository;
using CS412Final_Simeonov.Repository.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace CS412Final_Simeonov.DAL
{
    public static class UserDAL
    {
        static List<User> allUsers = Users.getAllUsers();
        private readonly static IError error = new Error();

        //READ
        public static User GetUser(string email, string password) {
            User user = null;
            string sqlQuery = @"SELECT * FROM `cs412`.`User` AS u, `cs412`.`address` AS a WHERE u.email = @email and u.password = @password and u.id = a.User_id;";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    user = new User()
                                    {
                                        Id = reader.GetInt64("Id"),
                                        Email = reader.GetNullString("email"),
                                        FirstName = reader.GetNullString("first_name"),
                                        LastName = reader.GetNullString("last_name"),
                                        Password = reader.GetNullString("password"),
                                        PhoneNumber = reader.GetNullString("phone_number"),
                                        TimeStamp = reader.GetNullString("create_time"),
                                        Address = new Address()
                                        {
                                            Id = reader.GetInt64("AddressId"),
                                            UserId = reader.GetInt64("USer_Id"),
                                            Street = reader.GetNullString("Street"),
                                            PostalCode = reader.GetNullString("Postal_code"),
                                            City = reader.GetNullString("City"),
                                            State = reader.GetNullString("State"),
                                            
                                        }
                                    };
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        error.Log(ex);
                    }
                }
            }
            return user;
            //return allUsers.Find(usr => {
            //    return usr.Email.Equals(email) && usr.Password.Equals(password);
            //});
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
        {//Some testing need it
            var index = allUsers.FindIndex(x => x.Id == user.Id);
            allUsers[index] = user;
            return user;
        }
    }
}