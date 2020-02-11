using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SushiStore.Controllers
{
    public class ForCustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}