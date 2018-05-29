using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumBasedOnPosition
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sumOdds = 0;
            int sumEvens = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEvens += number;
                }
                else
                {
                    sumOdds += number;
                }
            }

            var hasDifference = Math.Abs(sumOdds - sumEvens);
            if (hasDifference == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumOdds );
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + hasDifference);

            }
        }
    }
}
