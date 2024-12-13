using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Github_Portfolio_Projekt___Ayub_Mohamud.Bank_Account;
using static Github_Portfolio_Projekt___Ayub_Mohamud.Interface;

namespace Github_Portfolio_Projekt___Ayub_Mohamud
{
    internal class Simplifield
    {

        // Simplified Account Service Implementation
        public class AccountService : IAccountService
        {
            private List<BankAccount> accounts = new List<BankAccount>();
            private int nextId = 1;

            public void CreateAccount(string name)
            {
                var newAccount = new BankAccount { Id = nextId++, Name = name, Balance = 0 };
                accounts.Add(newAccount);
                Console.WriteLine($"Account created for {name} with ID {newAccount.Id}.");
            }

            public void Deposit(int accountId, decimal amount)
            {
                var account = accounts.FirstOrDefault(a => a.Id == accountId);
                if (account != null)
                {
                    account.Balance += amount;
                    Console.WriteLine($"Deposited {amount:C} to account {account.Name}. New balance: {account.Balance:C}");
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
            }

            public void Withdraw(int accountId, decimal amount)
            {
                var account = accounts.FirstOrDefault(a => a.Id == accountId);
                if (account != null)
                {
                    if (account.Balance >= amount)
                    {
                        account.Balance -= amount;
                        Console.WriteLine($"Withdrew {amount:C} from account {account.Name}. New balance: {account.Balance:C}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
            }

            public void DisplayAccounts()
            {
                if (accounts.Count == 0)
                {
                    Console.WriteLine("No accounts available.");
                }
                else
                {
                    foreach (var account in accounts)
                    {
                        Console.WriteLine($"ID: {account.Id}, Name: {account.Name}, Balance: {account.Balance:C}");
                    }
                }
            }
        }


    }
}
