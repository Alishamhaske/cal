using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class celsius
    {
        static void Main(string[] args)
        {

            double fahrenheit;

            Console.WriteLine("enter a celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius: " + celsius);
            //celsius into fahrenheit 
            //formula
            //Celsius =((Fahrenheit - 32)*5)/9;
            // //formula fahrenheit= (cel*9)/5 +32
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
        }
    }
}
