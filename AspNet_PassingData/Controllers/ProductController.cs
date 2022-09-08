using AspNet_PassingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //string veri gönderme
            string userName = "Uğur Şeşen";
            //string veriyi çevirmeye gerek yok aslında , ama başka type'ı farklı olabilir object çevirmekte fayda var.
            return View(userName as Object);
        }

        public IActionResult ProductGetAll()
        {
            Product product = new Product();
            product.ProductName = "LG TV";
            product.UnitPrice = 15000;
            return View(product);
        }

        public IActionResult GetProductsList()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ProductName="Bilgisayar",CategoryName="Elektronik",UnitPrice=7000},
                new Product(){ProductName="Monitor",CategoryName="Elektronik",UnitPrice=9500},
                new Product(){ProductName="Buzdolabı",CategoryName="Beyaz Eşya",UnitPrice=15000},
                new Product(){ProductName="Çamaşır Makinesi",CategoryName="Beyaz Eşya",UnitPrice=20000}
            };
            return View(products);
        }
    }
}
