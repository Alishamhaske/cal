using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int rev = 0;
            while (n != 0)
            {
                int rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;

            }
            Console.WriteLine("reverse num: " + rev);
            if(temp==rev)
            {
                Console.WriteLine("Palindrome ");
            }
            else
            {
                Console.WriteLine(" not Palindrome ");

            }
        }
    }
}
