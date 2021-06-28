using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tata_Power_App.Models;

namespace Tata_Power_App.Controllers
{
    public class BankAdminController : Controller
    {
        private readonly IBankService _bankService;

        public BankAdminController(IBankService bankService)
        {
            _bankService = bankService;
        }
        public IActionResult Index()
        {
            var bankUsers = _bankService.GetBankUsers;
            return View(bankUsers);
        }
        public IActionResult userDetail(int id)
        {
            var bankUser = _bankService.GetBankUser(id);
            return View(bankUser);
        }

        public IActionResult createUser()
        {
            return View();
        }
         
        [HttpPost]
        public IActionResult createUser(BankUser bankUser)
        {
            _bankService.addBankAccount(bankUser);
            return RedirectToAction("index", "bankadmin");
        }

        public IActionResult deleteAccount(int id)
        {
            _bankService.deleteBankAccount(id);
            return RedirectToAction("index", "bankadmin");
        }

        public IActionResult modifyAccount(int id)
        {
            var bankUser = _bankService.GetBankUser(id);
            // return RedirectToAction("index", "bankadmin");
            return View(bankUser);
        }

        [HttpPost]
        public IActionResult modifyAccount(BankUser bankUser)
        {
            //var bankUser = _bankService.GetBankUser(id);
            _bankService.modifyBankAccount(bankUser);
            return RedirectToAction("index", "bankadmin");
        }

    }
}
