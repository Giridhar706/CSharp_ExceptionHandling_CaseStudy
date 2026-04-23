using System;

namespace BankingSystem
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter account holder name: ");
            string name = Console.ReadLine() ?? "User";

            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine() ?? "0");

            BankAccount account = new BankAccount(name, balance);

            while (true)
            {
                Console.WriteLine("\n1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine() ?? "0");

                try
                {
                    if (choice == 1)
                    {
                        Console.Write("Enter amount: ");
                        double amt = double.Parse(Console.ReadLine() ?? "0");
                        account.Deposit(amt);
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter amount: ");
                        double amt = double.Parse(Console.ReadLine() ?? "0");
                        account.Withdraw(amt);
                    }
                    else if (choice == 3)
                    {
                        account.CheckBalance();
                    }
                    else if (choice == 4)
                    {
                        break;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid choice!");
                    }
                }
                catch (InvalidAmountException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (InsufficientBalanceException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong!");
                }
                finally
                {
                    Console.WriteLine("Transaction done.\n");
                }
            }
        }
    }
}
