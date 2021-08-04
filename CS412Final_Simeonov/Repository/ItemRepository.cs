using CS412Final_Simeonov.Models;
using CS412Final_Simeonov.Repository.Interfaces;
using CS412Final_Simeonov.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Repository
{
    public class ItemRepository : IItemRepository
    {
        public Item findItemById(long id)
        {
            return ItemDAL.GetItemById(id);
        }

        public List<Item> getAllItems()
        {
            return ItemDAL.GetAllItems();
        }

        public Boolean removeItem(Item item)
        {
            return ItemDAL.removeItem(item);
        }

        public void saveItem(Item item)
        {
            ItemDAL.saveItem(item);
        }

        public void updateItem(Item item)
        {
            ItemDAL.updateItem(item);
        }
    }
}