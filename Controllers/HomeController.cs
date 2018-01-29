using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class homeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }
}