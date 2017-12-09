using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class Booking
    {
        public int BookId { get; set; }           //порядковый номер книги
        public int BookingId { get; set; }      //номер брони
        public string User { get; set; }          //пользователь
        public DateTime Date { get; set; }        //дата
    }
}