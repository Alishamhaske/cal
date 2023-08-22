using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class area_circle
    {
        static void Main(string[] args)
        {
            int r;
            double a;
            Console.WriteLine("enter your number");
            r = Convert.ToInt32(Console.ReadLine());
            a = (3.14) * r * r;
            Console.WriteLine("area of circle" + a);
            Console.ReadLine();
        }
    }
}
