using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class For_1to20
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(" Think Quotient");
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine("Quoient");
                }
                else if (i%3==0)
                {
                    Console.WriteLine("Think");
                }
                else
                {
                    Console.WriteLine(i);
                }

                 

     
                
            }
            Console.ReadLine();

        }
    }
}
