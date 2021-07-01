using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS412Final_Simeonov.Repository.Interfaces
{
    interface IOrderRepository
    {
        List<Order> getAllOrdersForUser(User user);
        Boolean saveOrder(Order order);

        Boolean addItemToOrder(Item item);
    }
}
