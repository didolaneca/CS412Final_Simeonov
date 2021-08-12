﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Count { get; set; }
        public double Price { get; set; }



        //To DO replace Sting with the class containingn the images.
        public List<Image> Images { get; set; }
    }
}