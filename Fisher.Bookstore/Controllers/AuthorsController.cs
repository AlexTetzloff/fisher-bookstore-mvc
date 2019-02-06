using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            //return Content("This is the Authors controller’s Index action");
            return View();
        }
        public IActionResult Featured()
        {
            var featuredAuthor = new Fisher.Bookstore.Models.Author()
            {
                AuthorId = 1,
                Name = "J.K. Rowling"
            };
            return View(featuredAuthor);

       
    }
}
}