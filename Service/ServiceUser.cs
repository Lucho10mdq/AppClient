using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;

namespace Service
{
   public class ServiceUser
    {
        private UserRepository UserList = UserRepository.GetInstance();

        public User GetUserByEmail(string email,string password)
        {
            User oUser = null;
            var result = false;
            oUser = UserList.GetUserByEmail(email, password);

            if (oUser == null)
            {
                return  oUser;
                
            }
            else
            {
                if (oUser.Activo == false)
                {
                    result = false;
                }
                else
                {
                    return oUser;
                }
            }
            return oUser; 
        }
    }
}
