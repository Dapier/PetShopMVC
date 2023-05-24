using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class SalesController : Controller
    {
        public List<Sales> Ventas { get; set; }

        public SalesController()
        {
            Ventas = new List<Sales>()
            {
                new Sales()
                {
                  IdSale=1,IdUser=1,Total=10,DriveThru=true
                },
                new Sales()
                {
                  IdSale=2,IdUser=2,Total=9,DriveThru=false
                }
            };
        }
        public IActionResult Index()
        {
            return View(Ventas);
        }
    }
}
