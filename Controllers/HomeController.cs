using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tata_Power_App.Models;

namespace Tata_Power_App.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository _repository;

        public IRandomService _randomService;

        public HomeController(IStoreRepository repository, IRandomService randomService)
        {
            _repository = repository;
            _randomService = randomService;
        }
        public IActionResult Index()
        {
            //ProductInMemoryRepository productInMemory = new ProductInMemoryRepository();
            var product = _repository.products;
            var randomNum = $"Random number from service is {_randomService.getNumber()}";
            ViewBag.random = randomNum;
            //RedirectToPage("index", "BankAdmin");
            return View(product);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult buttonClick()
        {
            return RedirectToPage("index", "Customer");
        }
    }
}
