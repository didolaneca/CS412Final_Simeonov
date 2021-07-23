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
        public bool addNewOrder(Order order)
        {
            OrderDAL.addNewOrder(order);
            return true;
        }

        public List<Order> getAllOrdersForUser(User user)
        {
            return OrderDAL.GetAllOrders(user.Id);
        }

        public bool saveOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Boolean addItemToOrder(Item item, Order order) {

            order.Items.Add(item);
            return true;
        }
    }
}