using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(4"Type an option:\n");
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
                    Console.WriteLine("\nDeposit.");
                break;
                case '2':
                    Console.WriteLine("\nWithdraw.");
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
        }
    }
}