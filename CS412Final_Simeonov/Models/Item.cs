using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }

        public double Price { get; set; }


        //To DO replace Sting with the class containingn the images.
        public List<String> Images { get; set; }
    }
}