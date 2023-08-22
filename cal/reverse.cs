using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int rev = 0;
            while(n!=0)
            {
                int rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;

            }
            Console.WriteLine("reverse num: "+rev);
        }
    }
}


//123
//123%10=3
// rev= 0+3;
// 12
//12%10=2
//rev= 3*10+2= 32
//1%10= 32*10+1=321

