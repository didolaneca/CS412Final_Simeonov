using CS412Final_Simeonov.Models;
using CS412Final_Simeonov.Repository.Interfaces;
using CS412Final_Simeonov.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public bool addItemToOrder(Item item)
        {
            return OrderDAL.
        }

        public List<Order> getAllOrdersForUser(User user)
        {
            Or
        }

        public bool saveOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}