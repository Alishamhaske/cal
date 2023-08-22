using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class whileA_Z
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            while(ch<='Z')
            {
                Console.WriteLine(ch);
                ch++;
            }
        }
    }
}
