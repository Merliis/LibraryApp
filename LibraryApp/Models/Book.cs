using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }            //порядковый номер книги
        public int Quantity { get; set; }      //количество
        public string Name { get; set; }       //название
        public string Author { get; set; }     //автор
    }
}