using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class digit_mul
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int mul = 1;
            while(n!=0)
            {
                int rem = n % 10;
                mul = mul * rem;
                n = n / 10;
            }
            Console.WriteLine(mul);
        }
    }
}
