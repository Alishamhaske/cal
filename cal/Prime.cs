using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;

            for (int i = 2; i <= n/2 ; i++)
            {
                if (n % i == 0)
                {
                    a = 0;
                    break;

                }
            }
                if(a==0)
                {
                    Console.WriteLine("not prime");
                }
                else
                {
                    Console.WriteLine("prime num");
                }
            
        }
    }
}
