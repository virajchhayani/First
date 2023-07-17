using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ex8
    {
        private string accountNumber;
        private decimal balance;
        public ex8(string accountNumber)
        {
            this.accountNumber = accountNumber;
            balance = 0.0m;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Balance: {balance}");
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            ex8 account = new ex8(accountNumber);

            Console.Write("Enter amount to deposit: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.Write("Enter amount to withdraw: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            account.DisplayBalance();
        }
    }
}
