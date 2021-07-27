using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS412Final_Simeonov.BLL.Interfaces
{
    public interface IUserBLL
    {
        User FindUserByEmailAndPassword(string email, string password);
        User SaveUser(User user);
    }
}
