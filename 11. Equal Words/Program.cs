using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordOne = Console.ReadLine().ToLower();
            string wordTwo = Console.ReadLine().ToLower();

            bool equalWords = wordOne == wordTwo;

            if (equalWords)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
