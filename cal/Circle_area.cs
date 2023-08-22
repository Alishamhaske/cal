using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Circle_area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a radius:");
            int n = Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * n * n;

            Console.WriteLine("area= " + area);
        }
    }
}
