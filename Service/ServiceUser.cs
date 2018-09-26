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

        public bool AddUser(string name,string email,string password)
        {
            var result = false;
            if (UserList.GetUserByEmail(email, password) == null)
            {
                User oUser = new User(name, email, password, true);
                UserList.AddUser(oUser);
                result = true;
            }
            return result;
        }
    }
}
