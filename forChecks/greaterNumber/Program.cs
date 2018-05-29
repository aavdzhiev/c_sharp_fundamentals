using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = int.MinValue;

            for (var i = 1; i <= n; i++)
            {
                
                var number = int.Parse(Console.ReadLine());

                if (number > sum)
                {
                    sum = number;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
