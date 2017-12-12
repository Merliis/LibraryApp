using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class User
    {
        public int UserId { get; set; }    //идентификационный номер
        public string Password { get; set; }    //пароль
        public string Email { get; set; }       //почта и логин
        public string Name { get; set; }    //имя
        public int Role { get; set; }        //роль  0-гость, 1-читатель, 2-библиотекарь, 3-администратор
    }
   
}