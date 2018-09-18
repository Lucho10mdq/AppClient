using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    interface IUserRepository
    {
       User GetUserByEmail(string email, string password);
    }
}
