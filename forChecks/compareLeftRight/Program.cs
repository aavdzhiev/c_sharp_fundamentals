using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareLeftRight
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 1; i <= n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sumLeft += inputNumber;
            }

            for (int i = 1; i <= n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sumRight += inputNumber;
            }

            var remainder = Math.Abs(sumLeft - sumRight);

            if (remainder == 0)
            {
                Console.WriteLine("Yes, sum = " + sumLeft);
            }
            else
            {
                Console.WriteLine("No, diff = " + remainder);
            }
        }
    }
}
