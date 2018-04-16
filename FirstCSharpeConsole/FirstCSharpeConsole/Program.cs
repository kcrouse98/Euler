using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpeConsole
{
    class Program
    {
        static bool IsPalindrone(long lNumber)
        {
            bool bResult = false;
            long lReverse, lDigit, lRemainder;
            lReverse = lDigit = lRemainder = 0;

            // Start out with the full number;  We are going to build a mirror of it.
            lRemainder = lNumber;

            do
            {
                // Peel off the last number
                lDigit = lRemainder % 10;
                // Build up a new number which is the reverse of the original
                lReverse = (lReverse * 10) + lDigit;
                // Remove the last digit and do it all again.
                lRemainder = lRemainder / 10;
            } while (lRemainder != 0);



            if (lNumber == lReverse)
            {
                // We've got one!
                bResult = true;
            }

            return bResult;
        }

        static void Main(string[] args)
        {
            bool bbResult = false;
            long lLargest = 0;

            for(int x = 999; x > 1; x--)
            {
                for(int y = 999; y > 1; y--)
                {
                    bbResult = IsPalindrone(x * y);

                    if(bbResult == true)
                    {                      
                        if(x*y > lLargest)
                        {
                            lLargest = x * y;
                        }
   
                    }
                }
            }


            Console.WriteLine("Largest Palindrone: " + lLargest);


            Console.ReadLine();
        }
    }
}
