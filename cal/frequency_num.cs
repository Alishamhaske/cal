using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class frequency_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int copy = n;
            for(int i=0;i<=9;i++)
            {
                int count =0;
                while(n>0)
                {
                    int digit = n % 10;
                    if(digit==i)
                    {
                        count++;
                    }
                    n = n / 10;
                }
                Console.WriteLine(i+" "+count);
                n = copy;

            }
        }
    }
}
