using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, BankAccount> bankAccounts = new Dictionary<int, BankAccount>();
        string input;
        while((input = Console.ReadLine()) != "End")
        {
            string[] inputTokens = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = inputTokens[0];
            switch (command)
            {
                case "Create":
                    Create(inputTokens, bankAccounts);
                    break;
                case "Deposit":
                    Deposit(inputTokens, bankAccounts);
                    break;
                case "Withdraw":
                    Withdraw(inputTokens, bankAccounts);
                    break;
                case "Print":
                    Print(inputTokens, bankAccounts);
                    break;
                default:break;
            }   
        }
    }

    private static void Print(string[] inputTokens, Dictionary<int, BankAccount> bankAccounts)
    {
        int id = int.Parse(inputTokens[1]);
        if (!bankAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(bankAccounts[id]);
        }
    }

    private static void Withdraw(string[] inputTokens, Dictionary<int, BankAccount> bankAccounts)
    {
        int id = int.Parse(inputTokens[1]);
        decimal amount = decimal.Parse(inputTokens[2]);
        if (!bankAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if(bankAccounts[id].Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            bankAccounts[id].Withdraw(amount);
        }
    }

    private static void Deposit(string[] inputTokens, Dictionary<int, BankAccount> bankAccounts)
    {
        int id = int.Parse(inputTokens[1]);
        decimal amount = decimal.Parse(inputTokens[2]);
        if (!bankAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            bankAccounts[id].Deposit(amount);
        }
    }

    private static void Create(string[] inputTokens, Dictionary<int, BankAccount> bankAccounts)
    {
        int id = int.Parse(inputTokens[1]);
        if (bankAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount acc = new BankAccount();
            acc.Id = id;
            bankAccounts.Add(id, acc);
        }
    }
}

