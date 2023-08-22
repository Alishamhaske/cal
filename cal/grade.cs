using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class grade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter math mark");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter physics mark");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chemestry mark");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("math mark");
            Console.WriteLine("physics mark");
            Console.WriteLine("chemestry mark");
            int total = m + p + c;
            double per = total / 3;

            if (per >= 80)
            {
                Console.WriteLine($"Grade A {per}");
            }
            else if (per >= 70)
            {
                Console.WriteLine($"Grade B {per}");
            }
            else if (per >= 60)
            {
                Console.WriteLine($"Grade c {per}");
            }
            else if (per >= 40)
            {
                Console.WriteLine($"Grade D {per}");
            }
            else
            {
                Console.WriteLine($"Fail{per}");
            }





        }
    }
}
