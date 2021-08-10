using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Models
{
    public class Image
    {
        public long Id { get; set; }
        public String ImgSrc { get; set; }

        public String Description { get; set; }

        public long ItemId { get; set; }

    }
}