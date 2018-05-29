using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double dividedByTwo = 0;
            double dividedByThree = 0;
            double dividedByFour = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    dividedByTwo += 1;
                }
                if (number % 3 == 0)
                {
                    dividedByThree += 1;
                }
                if (number % 4 == 0)
                {
                    dividedByFour += 1;
                }


            }

            double p1 = dividedByTwo / n * 100;
            double p2 = dividedByThree / n * 100;
            double p3 = dividedByFour / n * 100;

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
