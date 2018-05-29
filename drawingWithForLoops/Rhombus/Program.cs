using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftEmptySpaces = n - 1;

            for (int i = 0; i < n; i++)
            {

                string whiteSpaces = new string(' ', leftEmptySpaces);

                Console.Write(whiteSpaces);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();

                leftEmptySpaces--;
            }

            leftEmptySpaces = 1;

            int stars = n - 1;


            for (int i = 0; i < n - 1; i++)
            {
                string whiteSpaces = new string(' ', leftEmptySpaces);

                Console.Write(whiteSpaces);

                for (int j = 0; j < stars; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine(whiteSpaces);

                leftEmptySpaces++;
                stars--;
            }

        }
    }
}
