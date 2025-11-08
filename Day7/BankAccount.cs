using System;
using System.Collections.Generic;

namespace MyApplication
{
    class BankAccount
    {
        private string name = "Opay";
        private double balance = 0.00;
        private int pin = 2027;
        private bool isAuthenticated = false;
        private List<string> transactions = new List<string>();

        public bool IsAuthenticated()
        {
            return isAuthenticated;
        }

        public void Login()
        {
            Console.WriteLine("Enter your PIN: ");
            int enteredPin = Convert.ToInt32(Console.ReadLine());

            if (enteredPin == pin)
            {
                isAuthenticated = true;
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
            }
        }

        private bool CheckAuth()
        {
            if (!isAuthenticated)
            {
                Console.WriteLine("Please login first!");
                return false;
            }
            return true;
        }

        public void Deposit()
        {
            if (!CheckAuth()) return;

            Console.WriteLine("How much do you want to deposit? ");
            double amount = Convert.ToDouble(Console.ReadLine());

            balance += amount;
            transactions.Add($"Deposited : {amount} | Balance : {balance} | Time {DateTime.Now}");
            Console.WriteLine($"Successfully deposited {amount}. New balance: {balance}");
        }

        public void Withdraw()
        {
            if (!CheckAuth()) return;

            Console.WriteLine("How much do you want to withdraw? ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= amount;
                transactions.Add($"Withdrew: {amount} | Balance: {balance} | Time: {DateTime.Now}");
                Console.WriteLine($"Successfully withdrew {amount}. New balance: {balance}");
            }
        }

        public void CheckBalance()
        {
            if (!CheckAuth()) return;

            Console.WriteLine($"Your balance is: {balance}");
        }

        public void TransactionHistory()
        {
            if (!CheckAuth()) return;

            Console.WriteLine("\n Transaction History");
            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions yet");
            }
            else
            {
                foreach (var transaction in transactions)
                {
                    Console.WriteLine(transaction);
                }
            }
        }

        public void changePin()
        {
            if (!CheckAuth()) return;

            Console.WriteLine("Enter current pin ");
            int current_pin = Convert.ToInt32(Console.ReadLine());
            if(current_pin != pin)
            {
                Console.WriteLine("Incorrect Pin");
            }
            else
            {
                Console.WriteLine("Please input your new 4 digit pin ");
                int new_pin = Convert.ToInt32(Console.ReadLine());
                if (new_pin.ToString().Length == 4)
                {
                    Console.WriteLine("Confirm new pin ");
                    int confirm_pin = Convert.ToInt32(Console.ReadLine());
                    
                    if(confirm_pin != new_pin) {
                        Console.WriteLine("Pin Mismatch");

                    }
                    else
                    {
                        pin = new_pin;
                        Console.WriteLine("You have successfully changed your pin");
                    }


                }
                else
                {
                    Console.WriteLine("Your new pin must be 4 digits");
                }
            }
        }
    }
}
