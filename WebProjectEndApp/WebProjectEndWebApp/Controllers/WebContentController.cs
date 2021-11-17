using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjectEndWebApp.Controllers
{
    public class WebContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
