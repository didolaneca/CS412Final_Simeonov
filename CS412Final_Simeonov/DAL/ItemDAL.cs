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
        static List<Item> allItems;
        private readonly static IError error = new Error();
        public ItemDAL() {
            allItems = new List<Item>();

            allItems.Add(new Item() { 
                Id = 1,
                Name = "MacBook Pro",
                Desciption = "Brand New Silver MacBook Pro",
                Price = 1199.99,
                Images = new List<string>() { "Some images" }
            });

        }

        //READ
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
                                        Desciption = reader.GetNullString("Description"),
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

        //DELETE - I don't think we should give ability to the user to delete their account
        public static Boolean removeItem(long id)
        {
            return allItems.Remove(GetItemById(id));
        }

        //ADD
        public static void addNewItem(Item item)
        {
            //INSERT INTO `cs412`.`Item` (`Id`, `Name`, `Description`, `Count`, `Price`) VALUES (NULL, 'Air Pods Pro', 'Air Pods Pro with charging case', 25, 229.99);

            string sql = @"INSERT INTO `cs412`.`Item` (`Id`, `Name`, `Description`, `Count`, `Price`) 
                            VALUES (NULL, @name, @desciption, @count, @price);";
            using (MySqlConnection connection = new MySqlConnection(WebConfigurationManager.AppSettings["connString"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@name", item.Name);
                        cmd.Parameters.AddWithValue("@description", item.Desciption);
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

        //Update???
    }
}