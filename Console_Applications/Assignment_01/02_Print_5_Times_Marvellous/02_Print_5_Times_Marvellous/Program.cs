using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Print_5_Times_Marvellous
{
    class Program
    {
        public static void Display()
        {
            int i = 0;

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Marvellous");
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
