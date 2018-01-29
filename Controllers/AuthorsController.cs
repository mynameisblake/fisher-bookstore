using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult index()
        {
            return Content("This is the author controller's Index Action");
        }

        public IActionResult Featured()
        {
            return Content("This is the author controller's Featured Action");
        }

    }
}