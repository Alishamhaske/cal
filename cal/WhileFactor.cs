using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class WhileFactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a num ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
           
            while(i<=num)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                   
                }
                i++;
               
            }

        }
    }
}
