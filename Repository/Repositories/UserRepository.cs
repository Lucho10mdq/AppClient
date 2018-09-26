using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Repository
{
    public class UserRepository: Singleton<UserRepository>,IUserRepository
    {
        private List<User> UserList = new List<User>();
        static UserRepository instance = null;
        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Clientes;Trusted_Connection=True;");

        public User GetUserByEmail(string email,string password)
         {
            User oUser = null;
            conexion.Open();

            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_UserByEmail";

            SqlParameter EmailParemeter = c.CreateParameter();
            EmailParemeter.ParameterName = "@email";
            EmailParemeter.SqlDbType = SqlDbType.VarChar;
            EmailParemeter.Value = email;
            c.Parameters.Add(EmailParemeter);

            SqlParameter PasswordParameter = c.CreateParameter();
            PasswordParameter.ParameterName = "@password";
            PasswordParameter.SqlDbType = SqlDbType.VarChar;
            PasswordParameter.Value = password;
            c.Parameters.Add(PasswordParameter);
            SqlDataReader dn = c.ExecuteReader();

            while (dn.Read())
            {
                string name = dn.GetString(4);
                string emails = dn.GetString(1);
                string pass = dn.GetString(2);
                bool activo = dn.GetBoolean(3);
                oUser = new User(name, email, password,activo);
                oUser.UserId = dn.GetInt32(0);
            }
            dn.Close();
            conexion.Close();
            return oUser;
        }

        public int AddUser(User oUser)
        {
             conexion.Open();
             SqlCommand c = conexion.CreateCommand();
             c.CommandType = CommandType.StoredProcedure;
             c.CommandText = "Add_User";
             c.Parameters.AddWithValue("name", oUser.Name);
             c.Parameters.AddWithValue("email", oUser.Email);
             c.Parameters.AddWithValue("password", oUser.Password);
             c.Parameters.AddWithValue("activo", oUser.Activo);
             int Affecterows = c.ExecuteNonQuery();
            conexion.Close();
            return Affecterows;
        }

        public List<User> GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
