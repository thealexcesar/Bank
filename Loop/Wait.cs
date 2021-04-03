using System;
using System.Threading;

namespace Loop
{
       public class Load
    {
        public void Couting()
        {
            Console.Write("Couting banknotes");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }
        }
        public void Waiting()
        {
            Console.Write("\nPlease wait");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
        }
        public void Printing()
        {
            Console.Write("\nPrinting");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
        }
    }
}