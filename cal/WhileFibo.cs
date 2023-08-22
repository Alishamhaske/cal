using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class WhileFibo
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, i = 2;

            Console.WriteLine("enter a number of elements");
            int no = Convert.ToInt32(Console.ReadLine());

            while(i<=no)
            {
                int f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
                i++;
            }

        }
    }
}
