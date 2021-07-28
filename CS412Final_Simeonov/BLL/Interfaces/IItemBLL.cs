using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS412Final_Simeonov.BLL.Interfaces
{
    interface IItemBLL
    {
        List<Item> GetAllItems();
        Item FindItemById(long id);
        Boolean AddNewItem(Item item);
        Boolean UpdateItem(Item item);
        Boolean DeleteItem(Item item);
    }
}
