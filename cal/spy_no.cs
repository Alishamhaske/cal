using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class spy_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            //spy number
            //123
            //1+2+3=6
            //1*2*3=6
            int sum = 0;
            int mul = 1;
            while (n != 0)
            {
                int rem = n % 10;
                sum = sum + rem;
                mul = mul * rem;
                n = n / 10;
            }
            Console.WriteLine("sum of digit:" + sum);
            Console.WriteLine("multiplication of digit:" + mul);
            if (sum==mul)
                {
                    Console.WriteLine("it is spy number:");

                }
                else
                {
                    Console.WriteLine("it is not spy number:");
                }

            

        }
    }
}
