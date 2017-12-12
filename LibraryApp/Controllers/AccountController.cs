using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FormsAuthApp.Models;
using LibraryApp.Models;

namespace LibraryApp.Controllers

{ 
    public class AccountController : Controller
    {
    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(LoginModel model)
    {
        if (ModelState.IsValid)
        {
            // ищем пользователя в базе данных
            User user = null;
            using (UserContext db = new UserContext())
            {
                user = db.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);

            }
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(model.Email, true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
            }
        }

        return View(model);
    }

    public ActionResult Registration()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Registration(RegistrationModel model)
    {
        if (ModelState.IsValid)
        {
            User user = null;
                using (UserContext db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Email == model.Email);
            }
            if (user == null)
            {
                //создание нового пользователя
                using (UserContext db = new UserContext())
                {
                    db.Users.Add(new User { Email = model.Email, Password = model.Password, Name = model.UserName });
                    db.SaveChanges();

                    user = db.Users.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
                }
                //успешное добавление пользователя в бд
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Пользователь с таким логином уже существует");
            }
        }

        return View(model);
    }
    public ActionResult Logoff()
    {
        FormsAuthentication.SignOut();
        return RedirectToAction("Index", "Home");
    }
}
}
