using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class divsible_5_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int no = Convert.ToInt32(Console.ReadLine());
            if (no % 5 == 0)
            {
                Console.WriteLine(" number divisble by 5 ");
            }
            else if (no % 11 == 0)
            {
                Console.WriteLine(" number divisble by 11");
            }
            else
            {
                Console.WriteLine("not divisible");
            }
        }
    }
}
