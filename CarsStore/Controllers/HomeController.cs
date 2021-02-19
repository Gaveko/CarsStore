using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarsStore.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryRepository repository;
        public HomeController(ICategoryRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}