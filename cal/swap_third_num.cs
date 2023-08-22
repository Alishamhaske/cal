using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class swap_third_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your 1st number");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your 2nd number");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping");
            Console.WriteLine("enter your 1st number" + no1);
            Console.WriteLine("enter your 1st number" + no2);

            no1 = no1 + no2;
            no2 = no1 - no2;
            no1 = no1 - no2;
            Console.WriteLine("After Swapping without third number");
            Console.WriteLine("enter your 1st number" + no1);
            Console.WriteLine("enter your 2nd number" + no2);
        }
    }
}
