using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{             // Bir sınıfı request alabilir ve response döndürebilir yani controller yapabilmek icin o sinifi
              // Controller classs'indan turetmemiz gerekmektedir.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Index3()
        {
            return View();
        }
    }
}
