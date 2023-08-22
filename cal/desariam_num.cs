using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class desariam_num
    {
        static void Main(string[] args)
        {
            // n=135
            // 1^1 +3^2 +5^3 ==135
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int temp = n;
            int sum = 0;
         
            while(n>0)
            {
              
                count++;
                n = n / 10;
              
            }
            n= temp;
            while(n>0)
            {
                int digit = n %10;
                int pow = 1;
                for(int i=1;i<=count;i++)
                {
                    pow = pow * digit;

                }
                sum = sum+ pow;
                count--;
                n = n / 10;

            }
            if(sum==temp)
            {
                Console.WriteLine("desariam number:");
            }
            else
            {
                Console.WriteLine("not desariam number");
            }

            

        }
    }
}
