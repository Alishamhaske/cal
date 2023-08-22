using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Aramstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;
            int temp = n;

            while(n!=0)
            {
                int rem = n % 10;
                sum =sum+ (rem*rem*rem);
                n = n / 10;

            }
            if(temp==sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }
            
        }
    }
}
