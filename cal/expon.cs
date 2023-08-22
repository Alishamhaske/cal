using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class expon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a exponent");
            int ex = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <= ex;i++)
            {
                
                res = res * n;

            }
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
