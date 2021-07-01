using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.DAL
{
    public class ItemDAL
    {
        static List<Item> allItems;
        public ItemDAL() {
            allItems = new List<Item>();
            //Item mac = new Item();
            //mac.Id.set(1); = 1;

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
            return allItems.Find(item => item.Id == id);
        }

        //DELETE - I don't think we should give ability to the user to delete their account
        public static Boolean removeItem(long id)
        {
            return allItems.Remove(GetItemById(id));
        }

        //ADD
        public static void addNewItem(Item item)
        {
            allItems.Add(item);
        }

        //Update???
    }
}