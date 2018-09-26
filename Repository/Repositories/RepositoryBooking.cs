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
    public class RepositoryBooking :Singleton<RepositoryBooking>, IBookingcs
    {
        private List<Booking> ListBooking = new List<Booking>();
        static RepositoryBooking instance = null;
        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Clientes;Trusted_Connection=True;");

        public int AddBooking(Booking oBooking)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Add_hiring";
            c.Parameters.AddWithValue("idClient", oBooking.IdClient);
            c.Parameters.AddWithValue("idTouristPackage", oBooking.IdTouristPackage);
            c.Parameters.AddWithValue("hiringDatetime", oBooking.BookingDate);

            int AffectedRows = c.ExecuteNonQuery();
            conexion.Close();
            return AffectedRows;

        }

        public int ModifyBooking(Booking oBooking)
        {
            throw new NotImplementedException();
        }
    }
}
