using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class fact1_2_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            //1!+2!+3!...
            int fact = 1;
            int sum = 0;

            for(int i = 1;i <=n;i++)
            {
                
                    fact = fact * i;
                    sum = sum + fact;
              
                
            }
            Console.WriteLine(sum);



        }
    }
}
