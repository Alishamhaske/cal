using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class std_avg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter marks of five subject");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            int mark2 = Convert.ToInt32(Console.ReadLine());
            int mark3 = Convert.ToInt32(Console.ReadLine());
            int mark4 = Convert.ToInt32(Console.ReadLine());
            int mark5 = Convert.ToInt32(Console.ReadLine());

            int sum = mark1 + mark2 + mark2 + mark3 + mark3 + mark4 + mark5;
            double avg = (sum / 5);
            Console.WriteLine("Average of 5 subject" + avg);


        }
    }
}
