using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Models
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string First { get; set; }

        public string Last { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}