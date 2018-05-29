using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double expenses = 0;


            if (budget <= 100)
            {
                if (season == "summer")
                {
                    expenses = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", expenses);
            }
                else if (season == "winter")
                {
                    expenses = budget * 70.0 / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", expenses);
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    expenses = budget * 40.0 / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", expenses);
                }
                else if (season == "winter")
                {
                    expenses = budget * 80.0 / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", expenses);
                }
            }
            else if (budget > 1000)
            {
                expenses = budget * 90.0 / 100;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", expenses);
                
            }
        }
    }
}
