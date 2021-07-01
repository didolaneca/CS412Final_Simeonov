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
            //Item mac = new Item();
            //mac.Id.set(1); = 1;
            Item itemOne = ItemDAL.GetItemById(1);

            allOrders.Add(new Order() { 
                Id = 1,
                Items = new List<Item>() { itemOne },
                //Can I access the Items List from the Order Object????
                TotalAmount = itemOne.Price
            });

        }


    }
}