using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SushiStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rolls()
        {
            return View("Index");
        }

        public IActionResult Sushi()
        {
            return View("Index");
        }

        public IActionResult Sets()
        {
            return View("Index");
        }

        public IActionResult Snacks()
        {
            return View("Index");
        }

        public IActionResult Drinks()
        {
            return View("Index");
        }
    }
}