using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Area_cir
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a base");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a height");
            int h = Convert.ToInt32(Console.ReadLine());

            double area = 0;
            area=(0.5) *( b * h);
            Console.WriteLine("area=" + area);


        }
    }
}
