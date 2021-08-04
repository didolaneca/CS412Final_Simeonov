using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Web.Configuration;
using CS412Final_Simeonov.Helpers;
using CS412Final_Simeonov.Repository.Interfaces;
using CS412Final_Simeonov.Repository;

namespace CS412Final_Simeonov.DAL
{
    public class ItemDAL
    {
        
        private readonly static IError error = new Error();
        
        //READ - Completed
        public static Item GetItemById(long id)
        {
            Item item;
            string sqlQuery = @"SELECT * FROM `cs412`.`Item` where Id = @id;";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    item = new Item()
                                    {
                                        Id = reader.GetInt64("Id"),
                                        Name = reader.GetNullString("name"),
                                        Description = reader.GetNullString("Description"),
                                        Count = reader.GetInt64("Count"),
                                        Price = reader.GetDouble("Price")
                                    };
                                    return item;
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


            return new Item();
        }

        //Completed
        //Fetch all items from DB and return a list of items 
        public static List<Item> GetAllItems()
        {
            List<Item> allItems = new List<Item>();
            Item item;
            string sqlQuery = @"SELECT * FROM `cs412`.`Item`;";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    item = new Item()
                                    {
                                        Id = reader.GetInt64("Id"),
                                        Name = reader.GetNullString("name"),
                                        Description = reader.GetNullString("Description"),
                                        Count = reader.GetInt64("Count"),
                                        Price = reader.GetDouble("Price")
                                    };
                                    allItems.Add(item);
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
            return allItems;
        }
        //Delete
        public static Boolean removeItem(Item item)
        {
            string sql = "DELETE FROM `cs412`.`Item` WHERE Id = @id;";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@id", item.Id);
                        cmd.ExecuteNonQuery();
                        return true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        error.Log(ex);
                        return false;
                    }
                }
            }
        }

        //ADD - Completed
        public static void saveItem(Item item)
        {
            //INSERT INTO `cs412`.`Item` (`Id`, `Name`, `Description`, `Count`, `Price`) VALUES (NULL, 'Air Pods Pro', 'Air Pods Pro with charging case', 25, 229.99);

            string sql = @"INSERT INTO `cs412`.`Item` (`Id`, `Name`, `Description`, `Count`, `Price`) 
                            VALUES (NULL, @name, @description, @count, @price);";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@name", item.Name);
                        cmd.Parameters.AddWithValue("@description", item.Description);
                        cmd.Parameters.AddWithValue("@count", item.Count);
                        cmd.Parameters.AddWithValue("@price", item.Price);
                        
                        cmd.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        error.Log(ex);
                    }
                }
            }
        }

        //Update 
        public static void updateItem(Item item)
        {
            //UPDATE `cs412`.`item` SET Name = 'Air Pods Pro', Description = 'Air Pods Pro with charging case', count = 30, price = 299.99 WHERE Id = 6;

            string sql = @"UPDATE `cs412`.`item` SET Name = @name,
                            Description = @description, count = @count, price = @price WHERE Id = @id;";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@name", item.Name);
                        cmd.Parameters.AddWithValue("@description", item.Description);
                        cmd.Parameters.AddWithValue("@count", item.Count);
                        cmd.Parameters.AddWithValue("@price", item.Price);
                        cmd.Parameters.AddWithValue("@id", item.Id);

                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        error.Log(ex);
                    }
                }
            }
        }
    }
}