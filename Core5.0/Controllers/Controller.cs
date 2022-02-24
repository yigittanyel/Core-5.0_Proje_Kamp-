using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5._0.Controllers
{
    public class Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
