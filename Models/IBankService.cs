using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tata_Power_App.Models
{
    public interface IBankService
    {
        public List<BankUser> GetBankUsers { get; }

        public BankUser GetBankUser(int id);

        public void addBankAccount(BankUser user);

        public void deleteBankAccount(int id);
        public void modifyBankAccount(BankUser bankUser);
    }
}
