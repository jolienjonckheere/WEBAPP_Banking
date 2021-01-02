using Banking.Models.Domain;
using System;
using System.Collections.Generic;
namespace Banking
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount account = new BankAccount("123-4567890-12");
            account.Deposit(200);
            WriteToConsole(account);
            account.Withdraw(100);
            WriteToConsole(account);
            IEnumerable<Transaction> transactions = account.GetTransactions(null, null);
            foreach (Transaction item in transactions)
            {
                Console.WriteLine($"Transaction: {item.DateOfTrans} - {item.Amount} - {item.TransactionType}");
            }
        }

        private static void WriteToConsole(BankAccount account)
        {
            Console.WriteLine($"Balance {account.Balance}");
            //Console.WriteLine("Balance " + account.Balance);
        }
    }
}
