using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.DAL
{
    public class OrderDAL
    {
        static List<Order> allOrders;
        public OrderDAL()
        {
            allOrders = new List<Order>();
            Item itemOne = ItemDAL.GetItemById(1);

            allOrders.Add(new Order() { 
                Id = 1,
                Items = new List<Item>() { itemOne },
                //Can I access the Items List from the Order Object????
                TotalAmount = itemOne.Price
            });
        }

        //READ
        public static Order GetOrderById(long id)
        {
            return allOrders.Find(order => order.Id == id);
        }

        //DELETE - I don't think we should give ability to the user to delete their account
        public static Boolean removeItem(long id)
        {
            return allOrders.Remove(GetOrderById(id));
        }

        //ADD
        public static void addNewOrder(Order order)
        {
            allOrders.Add(order);
        }

        public static List<Order> GetAllOrders(long userId) {
            //bug has be refactored orderId != userId
            return allOrders.Where(order => order.Id == userId).ToList<Order>();
        }

        //Update???


    }
}