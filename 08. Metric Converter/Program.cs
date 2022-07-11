using System;

namespace _08.Metric_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            string metric1 = Console.ReadLine().ToLower();
            string metric2 = Console.ReadLine().ToLower();

            double result = 0.00;

            if (metric1 == "mm" && metric2 == "mm")
            {
                result = num * 1;
            }

            if (metric1 == "mm" && metric2 == "cm")
            {
                result = num / 10;
            }

            if (metric1 == "mm" && metric2 == "m")
            {
                result = num / 1000;
            }

            if (metric1 == "mm" && metric2 == "mi")
            {
                result = (num / 1000) * 0.000621371192;
            }

            if (metric1 == "mm" && metric2 == "in")
            {
                result = (num / 1000) * 39.3700787;
            }

            if (metric1 == "mm" && metric2 == "km")
            {
                result = (num / 1000) * 0.001;
            }

            if (metric1 == "mm" && metric2 == "ft")
            {
                result = (num / 1000) * 3.2808399;
            }

            if (metric1 == "mm" && metric2 == "yd")
            {
                result = (num / 1000) * 1.0936133;
            }


            if (metric1 == "cm" && metric2 == "mm")
            {
                result = num * 10;
            }

            if (metric1 == "cm" && metric2 == "cm")
            {
                result = num * 1;
            }

            if (metric1 == "cm" && metric2 == "m")
            {
                result = num / 100;
            }

            if (metric1 == "cm" && metric2 == "mi")
            {
                result = (num / 100) * 0.000621371192;
            }

            if (metric1 == "cm" && metric2 == "in")
            {
                result = (num / 100) * 39.3700787;
            }

            if (metric1 == "cm" && metric2 == "km")
            {
                result = (num / 100) * 0.001;
            }

            if (metric1 == "cm" && metric2 == "ft")
            {
                result = (num / 100) * 3.2808399;
            }

            if (metric1 == "cm" && metric2 == "yd")
            {
                result = (num / 100) * 1.0936133;
            }


            if (metric1 == "m" && metric2 == "mm")
            {
                result = num * 1000;
            }

            if (metric1 == "m" && metric2 == "cm")
            {
                result = num * 100;
            }

            if (metric1 == "m" && metric2 == "mi")
            {
                result = num * 0.000621371192;
            }

            if (metric1 == "m" && metric2 == "in")
            {
                result = num * 39.3700787;
            }

            if (metric1 == "m" && metric2 == "km")
            {
                result = num * 0.001;
            }

            if (metric1 == "m" && metric2 == "m")
            {
                result = num * 1;
            }

            if (metric1 == "m" && metric2 == "ft")
            {
                result = num * 3.2808399;
            }

            if (metric1 == "m" && metric2 == "yd")
            {
                result = num * 1.0936133;
            }


            if (metric1 == "mi" && metric2 == "mm")
            {
                result = (num / 0.000621371192) * 1000;
            }

            if (metric1 == "mi" && metric2 == "cm")
            {
                result = (num / 0.000621371192) * 100;
            }

            if (metric1 == "mi" && metric2 == "m")
            {
                result = num / 0.000621371192;
            }

            if (metric1 == "mi" && metric2 == "mi")
            {
                result = num * 1;
            }

            if (metric1 == "mi" && metric2 == "in")
            {
                result = (num / 0.000621371192) * 39.3700787;
            }

            if (metric1 == "mi" && metric2 == "km")
            {
                result = (num / 0.000621371192) * 0.001;
            }

            if (metric1 == "mi" && metric2 == "ft")
            {
                result = (num / 0.000621371192) * 3.2808399;
            }

            if (metric1 == "mi" && metric2 == "yd")
            {
                result = (num / 0.000621371192) * 1.0936133;
            }


            if (metric1 == "in" && metric2 == "mm")
            {
                result = (num / 39.3700787) * 1000;
            }

            if (metric1 == "in" && metric2 == "cm")
            {
                result = (num / 39.3700787) * 100;
            }

            if (metric1 == "in" && metric2 == "m")
            {
                result = (num / 39.3700787);
            }

            if (metric1 == "in" && metric2 == "mi")
            {
                result = (num / 39.3700787) * 0.000621371192;
            }

            if (metric1 == "in" && metric2 == "in")
            {
                result = num * 1;
            }

            if (metric1 == "in" && metric2 == "km")
            {
                result = (num / 39.3700787) * 0.001;
            }

            if (metric1 == "in" && metric2 == "ft")
            {
                result = (num / 39.3700787) * 3.2808399;
            }

            if (metric1 == "in" && metric2 == "yd")
            {
                result = (num / 39.3700787) * 1.0936133;
            }


            if (metric1 == "km" && metric2 == "mm")
            {
                result = (num / 0.001) * 1000;
            }
            if (metric1 == "km" && metric2 == "cm")
            {
                result = (num / 0.001) * 100;
            }

            if (metric1 == "km" && metric2 == "m")
            {
                result = num / 0.001;
            }

            if (metric1 == "km" && metric2 == "mi")
            {
                result = (num / 0.001) * 0.000621371192;
            }

            if (metric1 == "km" && metric2 == "in")
            {
                result = (num / 0.001) * 39.3700787;
            }

            if (metric1 == "km" && metric2 == "km")
            {
                result = 1 * num;
            }

            if (metric1 == "km" && metric2 == "ft")
            {
                result = (num * 1000) * 3.2808399;
            }

            if (metric1 == "km" && metric2 == "yd")
            {
                result = (num / 0.001) * 1.0936133;
            }


            if (metric1 == "ft" && metric2 == "mm")
            {
                result = (num / 3.2808399) * 1000;
            }

            if (metric1 == "ft" && metric2 == "cm")
            {
                result = (num / 3.2808399) * 100;
            }

            if (metric1 == "ft" && metric2 == "m")
            {
                result = num / 3.2808399;
            }

            if (metric1 == "ft" && metric2 == "mi")
            {
                result = (num / 3.2808399) * 0.000621371192;
            }

            if (metric1 == "ft" && metric2 == "in")
            {
                result = (num / 3.2808399) * 39.3700787;
            }

            if (metric1 == "ft" && metric2 == "km")
            {
                result = (num / 3.2808399) * 0.001;
            }

            if (metric1 == "ft" && metric2 == "ft")
            {
                result = (num / 3.2808399) * 3.2808399;
            }

            if (metric1 == "ft" && metric2 == "yd")
            {
                result = (num / 3.2808399) * 1.0936133;
            }


            if (metric1 == "yd" && metric2 == "mm")
            {
                result = (num / 1.0936133) * 1000;
            }

            if (metric1 == "yd" && metric2 == "cm")
            {
                result = (num / 1.0936133) * 100;
            }

            if (metric1 == "yd" && metric2 == "m")
            {
                result = (num / 1.0936133);
            }

            if (metric1 == "yd" && metric2 == "mi")
            {
                result = (num / 1.0936133) * 0.000621371192;
            }

            if (metric1 == "yd" && metric2 == "in")
            {
                result = (num / 1.0936133) * 39.3700787;
            }

            if (metric1 == "yd" && metric2 == "km")
            {
                result = (num / 1.0936133) * 0.001;
            }

            if (metric1 == "yd" && metric2 == "ft")
            {
                result = (num / 1.0936133) * 3.2808399;
            }

            if (metric1 == "yd" && metric2 == "yd")
            {
                result = (num / 1.0936133) * 1.0936133;
            }


            Console.WriteLine(result + " " + metric2);
        }
    }
}
