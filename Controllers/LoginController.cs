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
    public class LoginController : Controller
    {
        private ApplicationDBContext _db;

        public LoginController(ApplicationDBContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            string us_name = HttpContext.Session.GetString("us_name");
            if(us_name!=null)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult LoginChecked(Login us)
        {
            string inputEmail = us.Email.ToLower();
            string inputPassword = us.Password;
            
            var obj = this._db.Members.Where(x => x.Email == inputEmail && x.Password == inputPassword).FirstOrDefault();
            if(obj == null)
            {
                TempData["LoginFail"] = "Wrong Email or Password"; 
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Session.SetString("us_name",obj.Email.ToLower());
                if(inputEmail=="admin@admin" && inputPassword==obj.Password)
                {
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    return RedirectToAction("Index","Customer");
                }
            }  
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("us_name");
            return RedirectToAction("Index","Login");
        }
    }
}