using System;
using Loop;

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
        } bool
        public void ToBalance()
        {
            int id = 1;

            const string ag = "Agency: 0001",
            nm = "Alex Cesar da Silva", 
            ph = "Phone number: 47-96586662",
            ad = "Blumenau-SC, Brasil",
            ac = "account: 3270000-4",
            bk = "PandaBank";

            Console.Write("\nType your cpf, only numbers: ");
            var cpf = Console.ReadKey(); 
            if (cpf.KeyChar == id)
            {
                new Load().Printing();
                Console.Write($"\n\nBalance: ${balance - withdrawed - transferred + deposited}\n");
                Console.WriteLine("----------------------------");
                Console.Write($"{nm}\n{ag}\n{ac}\n{ph}\n{ad}\n{bk}\n");
                Console.WriteLine("----------------------------");
            }
        }
    }
}