using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minValueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            for (var i = 1; i <= num; i++)
            {
                var number = int.Parse(Console.ReadLine());
          

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
