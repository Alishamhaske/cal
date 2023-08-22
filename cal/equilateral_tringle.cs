using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class equilateral_tringle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Length of radius");
            float r = float.Parse(Console.ReadLine());

            float root = (float)Math.Sqrt(3) / 4;
            float area = root * r * r;

            Console.WriteLine("Area of Equilateral Triangle is:\t" + area);

        }
    }
}
