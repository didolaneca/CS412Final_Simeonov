using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Models
{
    [Serializable]
    public class Address
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }

        public String PostalCode{ get; set; }

        public String Country { get; set; }

    }
}