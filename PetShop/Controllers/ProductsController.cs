using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class ProductsController : Controller
    {
        public List<Products> Productos { get; set; }

        public ProductsController()
        {
            Productos = new List<Products>()
            {
                new Products
                {
                  IdProduct=1,DescriptionProduct = "barato",TypeProduct=1,Amount=21,Unit="normal",UnitPrice=21
                },
                 new Products
                {
                  IdProduct=2,DescriptionProduct = "caro",TypeProduct=2,Amount=11,Unit="normal",UnitPrice=25
                }
            };
        }
        public IActionResult Index()
        {
            return View(Productos);
        }
    }
}
