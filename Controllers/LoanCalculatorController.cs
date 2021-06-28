using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tata_Power_App.Models;

namespace Tata_Power_App.Controllers
{
    public class LoanCalculatorController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }

        [HttpPost]*/
        public IActionResult Index(Loan loan)
        {
            var months = loan.years * 12 + loan.months;
            var rate = loan.interest/(12*100);
            var amount = loan.loanAmount;
            var emi = (amount * rate * Math.Pow((1 + rate),months))/(Math.Pow((1 + rate), months)-1);
            var floatEmi = (float)Math.Round(emi * 100f) / 100f;
            loan.emi = floatEmi.ToString();
            if (loan.emi == "NaN")
            {
                loan.emi = "";
            }
            return View(loan);
        }
    }
}
