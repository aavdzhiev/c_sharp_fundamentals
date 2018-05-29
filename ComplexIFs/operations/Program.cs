using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());

            double result = 0;

            switch (operand)
            {
                case '+':
                    result = a + b;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{a} {operand} {b} = {result} {(char)45} even");
                        
                    }
                    else
                    {
                        Console.WriteLine($"{a} {operand} {b} = {result} {(char)45} odd");
                    }
                    break;
                case '-':
                    result = a - b;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{a} {operand} {b} = {result} {(char)45} even");

                    }
                    else
                    {
                        Console.WriteLine($"{a} {operand} {b} = {result} {(char)45} odd");
                    }
                    break;
                case '*':
                    result = a * b;
                    if (b == 0)
                    {
                        Console.WriteLine($"{a} {operand} {b} = {result} {(char)45} even");

                    }
                    else
                    {
                        Console.WriteLine($"{a} {operand} {b} = {result} {(char)45} odd");
                    }
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", a);

                    }
                    else
                    {
                        result = a / (float)b;
                        Console.WriteLine($"{a} {operand} {b} = {result:f2}");
                    }
                    break;
                case '%':
                    
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", a);

                    }
                    else
                    {
                        result = a % b;
                        Console.WriteLine($"{a} {operand} {b} = {result}");
                    }
                    break;
            }
        }
    }
}
