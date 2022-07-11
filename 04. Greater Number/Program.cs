using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("Greater number:{0}", num1);
            }
            else
            {
                Console.WriteLine("Greater number:{0}", num2);
            }
        }
    }
}
