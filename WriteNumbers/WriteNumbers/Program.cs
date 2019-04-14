using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNumbers
{
    class Program
    {
        static int x = 700;
        static void Main(string[] args)
        {
            while (x < 1000)
            {
                Console.WriteLine(x);
                x++;

            }
            Console.ReadKey();
        }
    }
}
