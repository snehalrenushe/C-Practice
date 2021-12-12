using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Print_5_to_1_Numbers
{
    class Program
    {
        public static void Display()
        {
            int i = 0;
            i = 5;

            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.ReadKey();
        }
        static int Main(string[] args)
        {
            Display();

            return 0;
        }
    }
}
