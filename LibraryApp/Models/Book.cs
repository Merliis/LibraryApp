using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }               //порядковый номер книги
        public string Name { get; set; }          //название
        public string Author { get; set; }        //автор
        public string Genre { get; set; }         //жанр
        public string Publisher { get; set; }     //издательство
        public string Reservation { get; set; }   //в наличии
    }
}