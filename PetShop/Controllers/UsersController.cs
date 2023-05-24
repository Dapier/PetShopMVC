using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class UsersController : Controller
    {
        public List<Users> Usuarios { get; set; }
        public UsersController()
        {
            Usuarios = new List<Users>() {
                new Users(){
                IdUser = 1, Name = "David",LastName="Garza",Address = "San Nicolas",Role ="1",User= "Admin", Password= "papasfritas12"
                },
                new Users(){
                IdUser = 2, Name = "Pepe",LastName="Alvarado",Address = "Monterrey",Role ="2",User= "Miembro", Password= "loquesea42"
                }
            };
        }
        public IActionResult Index()
        {
            return View(Usuarios);
        }
    }
}
