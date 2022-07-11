using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 15 < 60)
            {
                minutes += 15;
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
            else
            {
                minutes = minutes + 15 - 60;
                hours++;

                if (hours < 24)
                {
                    Console.WriteLine($"{hours}:{minutes:D2}");
                }
                else
                {
                    hours -= 24;
                    Console.WriteLine($"{hours}:{minutes:D2}");
                }
            }
        }
    }
}
