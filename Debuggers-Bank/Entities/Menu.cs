namespace Debuggers_Bank.Entities
{
    internal class Menu
    {
        public void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("       Debuggers Bank");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Show all accounts");
                Console.WriteLine("3. Transfer money between accounts");
                Console.WriteLine("4. Exit");
                Console.WriteLine("==============================");
                Console.Write("Select an option: ");

                switch (Console.ReadLine()?.Trim())
                {
                    case "1":
                        Console.Clear();
                        Accounts.CreateAccount();
                        PauseForUser();
                        break;
                    case "2":
                        Console.Clear();
                        Accounts.ShowAccounts();
                        PauseForUser();
                        break;
                    case "3":
                        Console.Clear();
                        Accounts.TransferMoney();
                        PauseForUser();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Thank you for using Debuggers Bank!");

                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select 1, 2, 3 or 4.");
                        PauseForUser();
                        break;
                }
            }
        }

        private static void PauseForUser()
        {
            Console.WriteLine();
            Console.Write("Press Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
