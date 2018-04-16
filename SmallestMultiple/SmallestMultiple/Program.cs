using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bResult = false;
            bool bDivide = false;
            long lNumber = 20;
            int i = 1;

            do
            {
                bDivide = true;

                for (i = 3; i <= 20; i++)
                {
                    if (lNumber % i != 0)
                    {
                        bDivide = false;
                    }
                }

                if(bDivide == true)
                {
                    bResult = true;
                }
                else
                {
                    lNumber += 20;
                }

            } while (bResult != true);

            Console.WriteLine("Smallest Multiple: " + lNumber);

            Console.ReadLine();
        }
    }
}
