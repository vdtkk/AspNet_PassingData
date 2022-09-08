using AspNet_PassingData.Models;
using AspNet_PassingData.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_PassingData.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
            {
                new Customer(){CustomerName = "Miron Yazılım",CustomerAdress="CyberParck C Blok"},
                new Customer(){CustomerName = "ABC Yazılım",CustomerAdress= "Gölbaşı no:304"},
                new Customer(){CustomerName = "Mira Yazılım",CustomerAdress="OTDU Teknokent"},
            };

        

        public IActionResult UseViewModel()
        {
            Product product = new Product();
            product.ProductName = "Televizyon";
            product.CategoryName = "Elektronik";
            product.UnitPrice = 15000;

            CustomerandProductViewModel custproVM = new CustomerandProductViewModel();

   
            string date = DateTime.Now.ToString();

            custproVM.customers = customers;
            custproVM.product = product;
            custproVM.date = date;

            return View(custproVM);
        }

        public IActionResult UseTuple()
        {
            Product product = new Product();
            product.ProductName = "Buzdolabı";
            product.CategoryName = "Beyaz Eşya";
            product.UnitPrice = 25000;

            string date = DateTime.Now.ToString();

            (List<Customer>,Product,string) TupleData = (customers, product, date);
            return View(TupleData);
        }
    }
}
