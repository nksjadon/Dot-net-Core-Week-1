using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tata_Power_App.Models
{

    public class BankService : IBankService
    {
        static List<BankUser> bankUsers = new List<BankUser>
        {
            new BankUser
            {
                userId=1, userName="Narendra Kumar", userAddress="Delhi",
                userAccountBalance=10000, userAccountNumber = "122323232" 
            },
            new BankUser
            {
                userId=2, userName="Rahul Kumar", userAddress="Ghaziabad",
                userAccountBalance=20000, userAccountNumber = "422323232"
            }
        };

        public List<BankUser> GetBankUsers =>
            bankUsers;

        public void addBankAccount(BankUser user)
        {
            bankUsers.Add(user);
        }

        public void deleteBankAccount(int id)
        {
            BankUser bankUser = bankUsers.Find(x => x.userId == id);
            bankUsers.Remove(bankUser);
        }

        public BankUser GetBankUser(int id)
        {
            return bankUsers.Find(x => x.userId == id);
        }

        public void modifyBankAccount(BankUser bankUser)
        {
            BankUser oldAccount = bankUsers.FirstOrDefault(x => x.userId == bankUser.userId);
            oldAccount.userAccountBalance = bankUser.userAccountBalance;
            oldAccount.userName = bankUser.userName;
            oldAccount.userAccountNumber = bankUser.userAccountNumber;
            oldAccount.userAddress = bankUser.userAddress;
           
        }
    }
}
