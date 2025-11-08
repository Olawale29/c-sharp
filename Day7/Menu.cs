using System;

namespace MyApplication
{
    class Menu
    {
        BankAccount account = new BankAccount();

        public void Menus()
        {
            while (true) 
            {
                Console.WriteLine("=== Welcome to the ATM ===");
                account.Login();

                while (!account.IsAuthenticated())
                {
                    Console.WriteLine("You must login to continue.");
                    account.Login();
                }

                Console.WriteLine("\n====== ATM MENU ======");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Change Pin");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int pickedMenu;
                bool valid = int.TryParse(Console.ReadLine(), out pickedMenu);

                if (!valid)
                {
                    Console.WriteLine("Invalid Input. Please enter a number.");
                    continue;
                }

                switch (pickedMenu)
                {
                    case 1:
                        account.Deposit();
                        break;
                    case 2:
                        account.Withdraw();
                        break;
                    case 3:
                        account.CheckBalance();
                        break;
                    case 4:
                        account.changePin();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using our ATM. Goodbye!");
                        return; 
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

                MustRun();
            }
        }

        public void MustRun()
        {
            Console.WriteLine("\nPress ENTER to return to Menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
