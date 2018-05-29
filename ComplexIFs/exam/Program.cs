using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int arrivalSumMinutes = arrivalHour * 60 + arrivalMinutes;
            int examSumMinutes = examHour * 60 + examMinutes;
            int difference = examSumMinutes - arrivalSumMinutes;
            int delay = arrivalSumMinutes - examSumMinutes;

            if (arrivalSumMinutes > examSumMinutes)
            {

                Console.WriteLine("Late");
                if (delay < 60)
                {
                    Console.WriteLine("{0} minutes after the start", delay);
                }
                else if (delay >= 60)
                {
                    var hours = delay / 60;
                    var minutes = delay % 60;

                    if (minutes < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", hours, minutes);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", hours, minutes);
                    }
                }
            }
            else if (difference <= 30)
            {
                Console.WriteLine("On time");
                if (examSumMinutes == arrivalSumMinutes)
                {
                    
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", difference);
                }
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
                var hours = difference / 60;
                var minutes = difference % 60;

                if (difference < 60)
                {
                    Console.WriteLine("{0} minutes before the start", difference);
                }
                else if (difference >= 60 && minutes < 10)
                {
                    Console.WriteLine("{0}:0{1} hours before the start", hours, minutes);
                }
                else if (difference >= 60)
                {
                    Console.WriteLine("{0}:{1} hours before the start", hours, minutes);
                }
            }
        }
    }
}
