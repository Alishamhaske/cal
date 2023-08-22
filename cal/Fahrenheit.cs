using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Fahrenheit
    {
        //fahrenheit into celsius
        //formula
        //Celsius =((Fahrenheit - 32)*5)/9;
        //formula fahrenheit= (cel*9)/5 +32

        static void Main(string[] args)
        {

            Console.WriteLine("enter a fahrenhit value");
            Double F = Convert.ToDouble(Console.ReadLine());

            Double Celsius = ((F - 32) * 5) / 9;
            Console.WriteLine("fahrenhit into celsius" + Celsius);


        }
    }
}
