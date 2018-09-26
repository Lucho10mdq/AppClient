using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Repository
{
    interface IBookingcs
    {
        int AddBooking(Booking oBooking);
        int ModifyBooking(Booking oBooking);
    }
}
