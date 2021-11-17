using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjectEndWebApp.Controllers
{
    public class AboutWebContentController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
