using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string num = n.ToString();
            int sum = 0;

            for (int i = 0; i < num.Length; i++) 
            {
                sum += (n % 10);
                n /= 10;
            }

            Console.WriteLine(sum);

        }
    }
}

