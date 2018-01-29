using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class aboutController : Controller
    {
        public IActionResult index()
        {
            return Content("This is the about controller's Index Action");
        }

        public IActionResult History()
        {
            return Content("This is the about controller's History Action");
        }

        public IActionResult Location()
        {
            return Content("This is the Location Action");
        }
    }
}