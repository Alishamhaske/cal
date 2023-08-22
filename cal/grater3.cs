using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class grater3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first num");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third num");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("first number  is Greater" + n1);

                }
                else
                {
                    Console.WriteLine("third number is greater" + n3);
                }

            }
            else
            {
                Console.WriteLine("Second number is greater" + n2);
            }
        }
    }
}
