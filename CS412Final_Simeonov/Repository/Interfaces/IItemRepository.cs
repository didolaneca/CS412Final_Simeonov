using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Repository.Interfaces
{
    public interface IItemRepository
    {
       Item saveItem(Item item);

        List<Item> getAllItems();
        Item findItemById(long id);

        Boolean removeItem(Item item);
        void updateItem(Item item);
        Image saveImage(Image image);
    }
}