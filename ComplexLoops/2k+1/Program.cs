using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 1; i <= n; i = (i * 2) + 1)
            {
                Console.WriteLine(i);
                
            }
        }
    }
}
