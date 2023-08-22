using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class rect
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st num");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nt num");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int p = 2*(n1 + n2);
            Console.WriteLine("reactangle perimeter:" + p);

        }
    }
}
