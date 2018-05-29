using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int kilogramsVegetables = int.Parse(Console.ReadLine());
            int kilogramsFruits = int.Parse(Console.ReadLine());

            double income = (vegetablesPrice * kilogramsVegetables) + (fruitsPrice * kilogramsFruits);
            double incomeInEuro = income / 1.94;

            Console.WriteLine(incomeInEuro);
        }
    }
}
