using System;
using Services;
using Model;

namespace Bank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type an option:\n");
            Console.WriteLine("-------------");
            Console.WriteLine("1 - Deposit");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Deposit");
            Console.WriteLine("5 - Pix");
            Console.WriteLine("-------------");
            var input = Console.ReadKey();

            switch(input.KeyChar)
            {
                case '1':
                    new CurrentAccount().ToWithdrawal();
                break;
                case '2':
                    Console.WriteLine("test");
                break;
                case '3':
                    Console.WriteLine("\nTransfer.");
                break;
                case '4':
                    Console.WriteLine("\nDeposit.");
                break;
                case '5':
                    Console.WriteLine("\nPix.");
                break;
            }
            new Account().Owner();
            new Account().Another();
        }
    }
}