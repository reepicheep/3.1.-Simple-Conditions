using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Speed_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
            else if (speed > 150)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 50)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 10)
            {
                Console.WriteLine("average");
            }
            else
            {
                Console.WriteLine("slow");
            }
        }
    }
}
