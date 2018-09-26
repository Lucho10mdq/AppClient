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
    public class ClienteRepository:Singleton<ClienteRepository>,IClienteInterface
    {
        private List<Client> ClientList = new List<Client>();
        static ClienteRepository instance = null;
        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Clientes;Trusted_Connection=True;");

        public int Add(Client oClient)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Add_Client";
            c.Parameters.AddWithValue("name", oClient.Name);
            c.Parameters.AddWithValue("lastName", oClient.Lastname);
            c.Parameters.AddWithValue("dni", oClient.Dni);
            c.Parameters.AddWithValue("addres", oClient.Address);
            c.Parameters.AddWithValue("birthdate", oClient.FechaNacimiento);

            int AffectRows = c.ExecuteNonQuery();
            conexion.Close();
            return AffectRows;
        }

        public List<Client> GetAll()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_Clients";
            SqlDataReader dn = c.ExecuteReader();
            c.Prepare();
            ClientList.Clear();
            while (dn.Read())
            {
                string name = dn.GetString(1);
                string lastName = dn.GetString(2);
                string dni = dn.GetString(3);
                string address = dn.GetString(4);
                DateTime birthdate = dn.GetDateTime(5);
                Client oClient = new Client(name, lastName, dni, address, birthdate);
                oClient.ClientId = dn.GetInt32(0);
                ClientList.Add(oClient);
            }
            dn.Close();
            conexion.Close();
            return ClientList;
        }

        public Client GetByDni(string dni)
        {
            Client oClient = null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Get_ClientByDni";

            SqlParameter DniParameter = c.CreateParameter();
            DniParameter.ParameterName = "@dni";
            DniParameter.SqlDbType = SqlDbType.VarChar;
            DniParameter.Value = dni;
            c.Parameters.Add(DniParameter);


            SqlDataReader dn = c.ExecuteReader();

            while (dn.Read())
            {
                string name = dn.GetString(1);
                string surname = dn.GetString(2);
                string Dni = dn.GetString(3);
                var birthdate = dn.GetDateTime(5);
                string domicilio = dn.GetString(4);
                oClient = new Client(name, surname, dni, domicilio, birthdate);
                oClient.ClientId = dn.GetInt32(0);
            }
            dn.Close();
            conexion.Close();
            return oClient;
        }

        public int Modify(Client oCliente)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Update_Client";
            c.Parameters.AddWithValue("name", oCliente.Name);
            c.Parameters.AddWithValue("lastName", oCliente.Lastname);
            c.Parameters.AddWithValue("dni", oCliente.Dni);
            c.Parameters.AddWithValue("addres", oCliente.Address);
            c.Parameters.AddWithValue("birthdate", oCliente.FechaNacimiento);
            int affectedRows = c.ExecuteNonQuery();
            conexion.Close();
            return affectedRows;
        }
    }
}
