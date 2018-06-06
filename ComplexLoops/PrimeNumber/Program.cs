using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool primeOrNot = true;

            if (n < 2) primeOrNot = false;

            double sqroot = Math.Sqrt(n);

            for (int i = 2; i <= sqroot; i++)
            {
                if (n % i == 0)
                {
                    primeOrNot = false;
                }
            }

            if (primeOrNot == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
