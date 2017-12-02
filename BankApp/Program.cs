using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference, object, instance of a class
            var account = new Account
            {
                AccountName = "Mychecking",
                AccountType = TypeOfAccount.Checking,
                EmailAddress = "test@test.com"
            };

            account.Deposit(100.10M);
            Console.WriteLine($"AccountNumber:{account.AccountNumber}," +
                $"EmailAddress:{account.EmailAddress},Balance:{account.Balance}," +
                $"AccountType:{account.AccountType}");


            var account2 = new Account
            {
                EmailAddress = "test@test.com",
                AccountType = TypeOfAccount.Savings
            };
          
            account2.Deposit(100.10M);
            Console.WriteLine($"AccountNumber:{account2.AccountNumber}," +
                $"EmailAddress:{account2.EmailAddress},Balance:{account2.Balance}," +
                $"AccountType:{account2.AccountType}");

        }
    }
}
