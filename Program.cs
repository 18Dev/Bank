using System;

class BankAccount
{
    public string Owner;
    public decimal Balance;

    public BankAccount(string owner, decimal startingBalance)
    {
        Owner = owner;
        Balance = startingBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited ${amount}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Not enough money!");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Withdrew ${amount}");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: ${Balance}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        BankAccount account = new BankAccount(name, 100);

        while (true)
        {
            Console.WriteLine("\n=== BANK ===");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Amount: ");
                    account.Deposit(decimal.Parse(Console.ReadLine()));
                    break;

                case "2":
                    Console.Write("Amount: ");
                    account.Withdraw(decimal.Parse(Console.ReadLine()));
                    break;

                case "3":
                    account.ShowBalance();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}