using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Repository
{
    public class UserRepository:IUserRepository
    {
       
        public User GetUserByEmail(string dni)
           {
                    throw new NotImplementedException();
           }
    }
}
