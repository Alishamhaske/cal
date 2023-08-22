using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class ducknum
    {
        static void Main(string[] args)
        {
            //number contain one zero such as 101, 20, 230
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int rem = 0;
            int count = 0;

            while (n != 0)
            {
                rem = n % 10;
                n = n / 10;
                if(rem==0)
                {
                    count++;
                }

            }
                if (count == 1)
                {
                    Console.WriteLine("duck number");
                }
                else
                {
                    Console.WriteLine("not duck number ");
                }
            
        }
    }
}
