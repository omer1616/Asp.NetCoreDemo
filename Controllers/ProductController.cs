using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    { // Action metot: Controllera gelen istegi karsilayan ve gerekli operasyonlari gerceklestiren metotlardir.
        public IActionResult GetProducts()
        {
            Product product = new Product();

            //ViewResult result = new View(); => ilgili action ismiyle birebir ayni olani tetikler.
            ViewResult result =  View("product2"); // istenilen view'i tetikler.
            X();
            return result;
            //return View();
        }
        [NonAction]// Sadece is mantigiyla kullanacaksak disaridan gelen requestleri engellemek icin [NonAction] kullanılır.
        // Bu metot artik algoritma barindiran sadece is mantigi barindiran operatif bir metottur.
        public void X()
        {

        }
    }
}
