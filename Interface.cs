using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Portfolio_Projekt___Ayub_Mohamud
{
    internal class Interface
    {
        // Interface for Account Service
        public interface IAccountService
        {
            void CreateAccount(string name);
            void Deposit(int accountId, decimal amount);
            void Withdraw(int accountId, decimal amount);
            void DisplayAccounts();
        }
    }
}
