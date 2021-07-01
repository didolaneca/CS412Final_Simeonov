using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Models
{
    public class Order
    {
        public long Id { get; set; }
        public List<Item> Items { get; set; }

        //Payment method???
        public double TotalAmount { get; set; }
    }
}