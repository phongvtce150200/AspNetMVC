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
    public class ProductController : Controller
    {
        private ApplicationDBContext _db;
        public ProductController(ApplicationDBContext db)
        {
            this._db = db; 
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("us_name") == null)
            {
                return RedirectToAction("Index", "Login");
            }
            if(HttpContext.Session.GetString("us_name")!= "admin@admin")
            {
                return RedirectToAction("Index","Login");
            }
            else
            {
                string email = HttpContext.Session.GetString("us_name");
                ViewBag.LoginAccount = email;
                return View(this._db.Products);
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {

            if (ModelState.IsValid)
            {
                _db.Products.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);
        }
        public IActionResult Update(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Product obj = _db.Products.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Product obj)
        {

            if (ModelState.IsValid)
            {
                _db.Products.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);
        }
        public IActionResult Delete(int? Id){

            if (Id == null) 
            {
                return NotFound();
            }
            var obj = _db.Products.Find(Id);          
            if (obj == null) {
                return NotFound();
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProduct(int? id)
        {
            if (id == null) 
            {
                return NotFound();
            }
            var obj = _db.Products.Find(id);
            if (obj == null) 
            {
                return NotFound();
            }
            _db.Products.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}