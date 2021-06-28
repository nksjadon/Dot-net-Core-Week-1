using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tata_Power_App.Models
{
    public class BankUser
    {
        public int userId { get; set; }
        public int userAccountBalance { get; set; }
        public string userName { get; set; }
        public string userAddress { get; set; }
        public string userAccountNumber { get; set; }
    }
}
