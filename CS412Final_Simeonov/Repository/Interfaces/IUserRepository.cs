using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS412Final_Simeonov.Repository.Interfaces
{
    interface IUserRepository
    {
        User getUserDetails(String username, String password);
        Boolean saveUser(User user);
    }
}
