using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tata_Power_App.Models
{
    public class Loan
    {
        public long loanAmount { get; set; }
        public float interest { get; set; }
        public int years { get; set; }
        public int months { get; set; }

        public string emi { get; set; } = "";
    }
}
