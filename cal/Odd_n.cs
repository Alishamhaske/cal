using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Odd_n
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
           for(int i=1;i<=n;i++)
            {
                if(i%2!=0)
                {
                    sum = sum + i;

                  
                }
            }
            Console.WriteLine("sum" + sum);
        }
    }
}
