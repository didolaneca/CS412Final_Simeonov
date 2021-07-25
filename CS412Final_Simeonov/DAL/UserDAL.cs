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
        public static User GetUser(string email, string password)
        {
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
            string sql = @"INSERT INTO `cs412`.`User` (`id`, `first_name`, `last_name`, `email`, `username`, `password`, `phone_number`, `create_time`, `orders`, `address`) VALUES (NULL, @first_name, @last_name, @email, @username, @Password, @phone_number, CURRENT_TIMESTAMP, NULL, @address);";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                        cmd.Parameters.AddWithValue("@last_name", user.LastName);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@phone_number", user.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@address", user.Address.UserId);
                        //Breaking here????
                        cmd.ExecuteNonQuery();
                        SaveAddress(user.Address);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        error.Log(ex);
                    }
                }
            }
        }


        public static void SaveAddress(Address address)
        {

            //INSERT INTO `cs412`.`Address` (`Id`, `User_id`, `Street`, `City`, `State`, `Postal_code`, `Country`)
            //VALUES(NULL, 3, "Odin Palaca", "Asgard", "Asgard", "55544", "Asgard");
            string sql = @"INSERT INTO `cs412`.`Address` (`Id`, `User_id`, `Street`, `City`, `State`, `Postal_code`, `Country`) 
                            VALUES
                            (NULL, @User_Id, @Street, @City, @State, @Postal_code, @Country);";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@User_Id", address.UserId);
                        cmd.Parameters.AddWithValue("@Street", address.Street);
                        cmd.Parameters.AddWithValue("@City", address.City);
                        cmd.Parameters.AddWithValue("@State", address.State);
                        cmd.Parameters.AddWithValue("@Postal_code", address.PostalCode);
                        cmd.Parameters.AddWithValue("@Country", address.Country);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        error.Log(ex);

                    }
                }
            }
        }

        //Update??? we can use the  saveuser to update?
        //This method expects already modified user object with the new user info so before calling this method
        // we have to fetch the original user object from DB modify the fields need it then call this method
        public static User UpdateUser(User user)
        {//Some testing need it
            //@"SELECT * FROM `cs412`.`User` AS u, `cs412`.`address` AS a WHERE u.email = @email and u.password = @password and u.id = a.User_id;";
            string sqlQuery = @"UPDATE `cs412`.`User` SET first_name = @first_name, last_name = @last_name, email = @email,
                                username = @username, password = @Password, phone_number = @phone_number, 
                                create_time = CURRENT_TIMESTAMP WHERE Id = @user_id;";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        try
                        {
                            cmd.Connection.Open();
                            cmd.Parameters.AddWithValue("@user_id", user.Id);
                            cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                            cmd.Parameters.AddWithValue("@last_name", user.LastName);
                            cmd.Parameters.AddWithValue("@email", user.Email);
                            cmd.Parameters.AddWithValue("@username", user.Username);
                            cmd.Parameters.AddWithValue("@phone_number", user.PhoneNumber);
                            cmd.Parameters.AddWithValue("@Password", user.Password);
                            cmd.Parameters.AddWithValue("@address", user.Address.UserId);
                            cmd.ExecuteNonQuery();
                            SaveAddress(user.Address);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            error.Log(ex);
                        }
                    }
                    catch (Exception ex)
                    {
                        error.Log(ex);
                    }
                }

                //var index = allUsers.FindIndex(x => x.Id == user.Id);
                //allUsers[index] = user;
                //return user;
            }
            return user;
        }

        public static long LastUserId()
        {
            string sql = @"SELECT MAX(id) FROM `cs412`.`User`;";
            long lastUserId = 0;
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    lastUserId = reader.GetInt64("MAX(id)");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        error.Log(ex);
                        return 0;
                    }
                }
            }
            return lastUserId;
        }
    }
}