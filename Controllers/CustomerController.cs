using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.DB;
using Assignment1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDBContext _db;
        public CustomerController(ApplicationDBContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("us_name") != "admin@admin")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult ChangeInfomation()
        {
            string username = HttpContext.Session.GetString("us_name");

            Member obj = _db.Members.Where(x => x.Email == username).FirstOrDefault();
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult ChangeInfomation(Member obj)
        {
            string username = HttpContext.Session.GetString("us_name");
            Member user = _db.Members.FirstOrDefault(x => x.Email == username);
            obj.Password = user.Password;
            if (ModelState.IsValid)
            {
                user.Email = obj.Email;
                user.CompanyName = obj.CompanyName;
                user.City = obj.City;
                user.Country = obj.Country;
                
                _db.Members.Update(user);

                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult ChangePassword()
        {
            string username = HttpContext.Session.GetString("us_name");
            return View();
        }
       
        [HttpPost]
        public IActionResult ChangePassword(ChangePassword obj)
        {
            string username = HttpContext.Session.GetString("us_name");
            Member user = _db.Members.FirstOrDefault(x => x.Email == username);
            if (user.Password == obj.Password)
            {
                if (ModelState.IsValid)
                {
                    user.Password = obj.NewPassword;

                    _db.Members.Update(user);

                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }

            }else
            ViewData["wrongCurrentPass"] = "Wrong Current Pass";

            return View(obj);

        }
        public IActionResult ViewOrder()
        {
            string username = HttpContext.Session.GetString("us_name");
            ViewData["usname"]= username;
            Member obj = _db.Members.Where(x => x.Email == username).FirstOrDefault();
            if (obj == null)
            {
                return NotFound();
            }
            IEnumerable<Order> orderList = _db.Orders.Where(x => x.MemberId == obj.MemberId);
            return View(orderList);
        }

    }

}