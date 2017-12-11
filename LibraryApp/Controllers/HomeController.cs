using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryApp.Models;

namespace LibraryApp.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            var books = db.Books;
            ViewBag.Books = books;
            return View(db.Books);
        }
        [HttpGet]
        public ActionResult BookBookings(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string BookBookings(Booking booking)
        {
            booking.Date = DateTime.Now;
            db.Booking.Add(booking);
            db.SaveChanges();
            return "Спасибо," + booking.User + ", выбранная книга забронирована для получения";
        }
        public ActionResult About()
        {
            ViewBag.Message = " ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = " ";

            return View();
        }
    }
}
