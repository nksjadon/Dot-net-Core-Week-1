using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tata_Power_App.Models;

namespace Tata_Power_App.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer
            {
                customerId = 1, customerName="Narendra Kumar", customerAddress = "Vasundhra, Ghaziabad"
            };
            return View(customer);
        }
    }
}
