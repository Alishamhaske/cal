using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class day_switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("monday");
                    break;
                case 3:
                    Console.WriteLine("thuesday");
                    break;
                case 4:
                    Console.WriteLine("wednesday");
                    break;
                case 5:
                    Console.WriteLine("thurday");
                    break;
                case 6:
                    Console.WriteLine("friday");
                    break;
                case 7:
                    Console.WriteLine("satdarday");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }



        }
    }
}
