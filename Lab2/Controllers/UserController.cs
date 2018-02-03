using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Data.Entities;
using Lab2.Data;

namespace Lab2.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if(user.FirstName.Length != 0 && user.LastName.Length != 0 && user.EmailAddress.Length != 0)
            { 
                user.Id = InMemoryDB.NextId();
                InMemoryDB.Users.Add(user);
            }
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var users = InMemoryDB.Users;

            return View(users);
        }
    }
}