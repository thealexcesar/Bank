using System;
using Model;

namespace Services
{
    public class CurrentAccount
    {
        public void ToWithdrawal()
        {
            Console.Write("\nName: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            
            Console.Write("Withdrawal amount: ");
            var amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You requested: ${amount}");
        }
    }
}