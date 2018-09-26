using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class ServiceBooking
    {
        private RepositoryBooking ListBooking = RepositoryBooking.GetInstance();

        public void AddBooking(int idClient,int idTourist,DateTime BookingDate)
        {
            Booking oBooking = new Booking(idClient, idTourist, BookingDate);
            ListBooking.AddBooking(oBooking);
        }
    }
}
