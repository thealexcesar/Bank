using System;

namespace Model
{
    public class Account
    {
        public double Withdrawal {get; set;}
        public double Balance {get; set;}
        
        // Data Clients
        public void Owner()
        {
            const string ag = "Agency: 0001",
            nm = "Name: Alex Cesar da Silva", 
            ph = "Phone number: 47-96586662",
            ad = "Address: Blumenau-SC, Brasil",
            ac = "Current account: 3270000-4",
            bk = "Bank: PandaBank";

            Console.WriteLine("----------------------------");
            Console.Write($"{nm}\n{ag}\n{ac}\n{ph}\n{ad}\n{bk}\n");
            Console.WriteLine("----------------------------");
        }
        public void Another()
        {
            const string ag1 = "Agency: 0002",
            nm1 = "Name: Gleiciane Rodrigues", 
            ph1 = "Phonen number: 01-90001000",
            ad1 = "Address: Blumenau-SC, Brasil",
            ac1 = "Account: 3270000-9",
            bk1 = "Bank: PandaBank";
            
            Console.WriteLine("----------------------------");
            Console.Write($"{nm1}\n{ag1}\n{ac1}\n{ph1}\n{ad1}\n{bk1}\n");
            Console.WriteLine("----------------------------");
        }
    }
}