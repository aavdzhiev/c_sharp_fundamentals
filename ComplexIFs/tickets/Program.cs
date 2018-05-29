using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var people = int.Parse(Console.ReadLine());

            var moneyLeft = 0.0;
            var moneyNeeded = 0.0;
            var result = 0.0;

            if (people >= 1 && people <=4)
            {
                moneyLeft = budget - (0.75 * budget);
            }
            else if (people >=5 && people <= 9)
            {
                moneyLeft = budget - (0.60 * budget);
            }
            else if (people >= 10 && people <= 24)
            {
                moneyLeft = budget - (0.50 * budget);
            }
            else if (people >= 25 && people <= 49)
            {
                moneyLeft = budget - (0.40 * budget);
            }
            else if (people >= 50)
            {
                moneyLeft = budget - (0.25 * budget);
            }


            if (category == "vip")
            {
                moneyNeeded = 499.99 * people;
            }
            else if (category == "normal")
            {
                moneyNeeded = 249.99 * people;
            }

            if (moneyLeft >= moneyNeeded)
            {
                result = moneyLeft - moneyNeeded;
                Console.WriteLine("Yes! You have {0:f2} leva left.", result);
            }
            else if (moneyLeft < moneyNeeded)
            {
                result = moneyNeeded - moneyLeft;
                Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
            }
        }
    }
}
