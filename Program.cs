using System;
using Service;
using Model;
using Loop;

namespace Bank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type an option:\n");
            Console.WriteLine("-------------");
            Console.WriteLine("1 - Balance");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Deposit");
            Console.WriteLine("5 - Pix");
            Console.WriteLine("-------------");
            var input = Console.ReadKey();

            switch(input.KeyChar)
            {
                case '1':
                    new Load().Printing();
                    new AccountService().ToBalance();
                    new Account().Owner();
                break;
                case '2':
                    new AccountService().ToWithdrawal();
                    new Load().Couting();
                    Console.WriteLine("\nTake your money!");
                break;
                case '3':
                    new Load().Waiting();
                    new AccountService().ToTransfer();
                    Console.WriteLine("Transferred from");
                    new Account().Owner();
                    Console.WriteLine($"\nBenefited");
                    new Account().Another();
                break;
                case '4':
                    new Load().Waiting();
                    new AccountService().ToDeposit();
                    Console.WriteLine($"\nDepositor");
                    new Account().Owner();
                    Console.WriteLine($"\nBenefited");
                    new Account().Another();

                break;
                case '5':
                    Console.WriteLine("\nPix.");
                break;
            }
        }
    }
}