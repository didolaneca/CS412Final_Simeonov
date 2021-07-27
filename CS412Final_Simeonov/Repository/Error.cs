using CS412Final_Simeonov.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Repository
{
    public class Error : IError
    {
        public bool Log(Exception ex)
        {
            //To DO :))) log error to the database
            return false;
        }
    }
}