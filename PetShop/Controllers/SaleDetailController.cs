using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class SaleDetailController : Controller
    {
        public List<SaleDetail> DetallesVentas { get; set; }
        public SaleDetailController()
        {
            DetallesVentas = new List<SaleDetail>()
            {
                new SaleDetail
                {
                    IdSaleDetail=1,IdSale=1,IdProduct=1,Amount=21,UnitPrice=14,SubTotal=14
                },
                new SaleDetail
                {
                    IdSaleDetail=2,IdSale=2,IdProduct=2,Amount=11,UnitPrice=21,SubTotal=21
                }
            };
        }
        public IActionResult Index()
        {
            return View(DetallesVentas);
        }
    }
}
