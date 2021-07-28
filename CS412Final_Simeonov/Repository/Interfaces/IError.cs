using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Repository.Interfaces
{
    interface IError
    {
        bool Log(Exception ex);
    }
}