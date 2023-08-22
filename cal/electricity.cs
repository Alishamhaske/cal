using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class electricity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter eletricity unit");
            int unit = Convert.ToInt32(Console.ReadLine());
            double cal = 0;

            if (unit <= 50)
            {
                cal = unit * 0.50;
                Console.WriteLine("charge is" + cal);
            }
            else if (unit >= 50 && unit <= 100)
            {
                cal = (unit * 0.50) + (unit - 50 * (0.75));
                Console.WriteLine("charge is" + cal);
            }
            else if (unit >= 100 && unit <= 200)
            {
                cal = (unit * 0.50) + (unit - 50 * (0.75)) + (unit - 100 * (1.20));
                Console.WriteLine("charge is" + cal);
            }
            else if (unit >= 200 && unit <= 250)
            {
                cal = (unit * 0.50) + (unit - 50 * (0.75)) + (unit - 100 * (1.20)) + (unit - 200 * (1.50));
                Console.WriteLine("charge is" + cal);
            }
            else
            {
                cal = ((unit * 0.50) + (unit - 50 * (0.75)) + (unit - 100 * (1.20)) + (unit - 200 * (1.50)) + (unit - 250 * (1.50))) * 20;
                Console.WriteLine("charge is" + cal);

            }

        }
    }
}
