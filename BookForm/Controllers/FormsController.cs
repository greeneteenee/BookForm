using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookForm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookForm.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection formData)
        {
            //Map form data to Book Object
            Book book = new Book();
            book.BookTitle = formData["book-title"];
            book.Author = formData["author"];
            book.Isbn = formData["isbn"];
            book.PublicationDate = Convert.ToDateTime(formData["publication-date"]);

            //Add to database

            ViewData["Message"] = "Book added successfully";

            return View();
        }
    }
}