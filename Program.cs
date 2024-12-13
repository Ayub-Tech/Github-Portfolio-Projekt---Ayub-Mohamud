using static Github_Portfolio_Projekt___Ayub_Mohamud.Interface;
using static Github_Portfolio_Projekt___Ayub_Mohamud.Simplifield;

namespace Github_Portfolio_Projekt___Ayub_Mohamud
{
            // Main Program
class Program
        {
            static void Main(string[] args)
            {
                IAccountService accountService = new AccountService();
                bool running = true;

                while (running)
                {
                    Console.WriteLine("\n--- Bank Application ---");
                    Console.WriteLine("1. Create Account");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. View Accounts");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choose an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("Enter your name: ");
                            string name = Console.ReadLine();
                            accountService.CreateAccount(name);
                            break;
                        case "2":
                            Console.Write("Enter Account ID: ");
                            int depositId = int.Parse(Console.ReadLine());
                            Console.Write("Enter amount to deposit: ");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            accountService.Deposit(depositId, depositAmount);
                            break;
                        case "3":
                            Console.Write("Enter Account ID: ");
                            int withdrawId = int.Parse(Console.ReadLine());
                            Console.Write("Enter amount to withdraw: ");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            accountService.Withdraw(withdrawId, withdrawAmount);
                            break;
                        case "4":
                            accountService.DisplayAccounts();
                            break;
                        case "5":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
            }
        }
    }