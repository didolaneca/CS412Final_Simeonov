using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Repository.Interfaces
{
    interface IItemRepository
    {
        Boolean saveItem(Item item);

        Item findItemById(long id);

        Boolean removeItem(long id);
    }
}