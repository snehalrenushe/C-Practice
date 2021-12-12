using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Divide_Two_Numbers
{
    class Program
    {
        public static int Divide(int iNo1, int iNo2)
        {
            int iAns = 0;

            if (iNo2 == 0)
            {
                return -1;
            }

            iAns = iNo1 / iNo2;

            return iAns;
        }
        static int Main(string[] args)
        {
            int iValue1 = 15, iValue2 = 5;
            int iRet = 0;

            iRet = Divide(iValue1,iValue2);

            Console.WriteLine("Division is " + iRet);

            Console.ReadKey();

            return 0;
        }
    }
}
