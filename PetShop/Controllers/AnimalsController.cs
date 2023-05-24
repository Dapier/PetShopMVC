using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class AnimalsController : Controller
    {
        public List<Animals> Animales { get; set; }
        public AnimalsController()
        {
            Animales = new List<Animals>() {
                new Animals() {
                IdAnimal = 1, Breed = "Chihuahua",Age = 1, AgeDescription = "young", Color = "Negro"
            },
                 new Animals() {
                IdAnimal = 2, Breed = "Husky",Age = 3, AgeDescription = "old", Color = "Blanco"
            },
            };
        }
        public IActionResult Index()
        {
            return View(Animales);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
