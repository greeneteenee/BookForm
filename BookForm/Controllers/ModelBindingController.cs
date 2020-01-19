using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookForm.Controllers
{
    public class ModelBindingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Book book)//mapping is done authomatically
        {
            if (ModelState.IsValid)
            {
                //Add to database

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

    }
}