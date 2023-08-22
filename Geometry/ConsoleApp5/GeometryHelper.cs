using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal static class GeometryHelper
    {
        public static void Area(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Please add correct numbers");
                return;
            }
            Console.WriteLine(a*b);
        }

        public static void Area(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Please add correct numbers");
                return;
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            Console.WriteLine(area);
        }
        public static void Area(double a)
        {
            if (a <= 0)
            {
                Console.WriteLine("Please add correct numbers");
                return;
            }
            double area = a * a * Math.PI;
            Console.WriteLine(area);
        }
    }
}
