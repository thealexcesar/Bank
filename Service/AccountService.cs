using System;

namespace Service
{
    public class AccountService
    {
        double balance = 1250, deposited, withdrawed, transferred;
        public void ToWithdrawal()
        {
            Console.Write("\nName: ");
            var name = Console.ReadLine();
            Console.Write($"Hello, {name}! ");
            
            Console.Write("How much do you want to withdraw? ");
            withdrawed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Balance: ${balance}");
            Console.WriteLine($"You withdrawed: ${withdrawed}");
            Console.WriteLine($"Currency balance: ${balance - withdrawed}");
        }
        public void ToDeposit()
        {
            Console.Write("\nName: ");
            var name = Console.ReadLine();
            Console.Write($"Hello, {name}! ");
            
            Console.Write("How much do you want to deposit? ");
            deposited = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Deposited amount: ${deposited}");
            Console.WriteLine($"Balance: ${balance + deposited}");
            Console.WriteLine("----------------------------");

        } 
        public void ToTransfer()
        {
            Console.Write("\nName: ");
            var name = Console.ReadLine();
            Console.Write($"Hello, {name}! ");
            
            Console.Write("How do you much to transfer? ");
            transferred = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You transferred: ${transferred}");
            Console.WriteLine($"\nBalance: ${balance - transferred}");
        } 
        public void ToBalance()
        {
            Console.Write($"\n\nBalance: ${balance - withdrawed - transferred + deposited}\n");
        }  
    }
}