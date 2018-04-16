using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001Prime
{
    class Program
    {
        static bool IsPrime(double lNumber)
        {
            bool bResult = true;

            if (lNumber == 2)
            {
                // 2 is a Prime Number
                bResult = true;
            }
            else if (lNumber % 2 == 0)
            {
                // If it is divisible by 2, it is not Prime
                bResult = false;
            }
            else
            {
                // Now we need to check every odd value between 3 and the square root of the number.
                for (double lIterator = 3; lIterator <= Math.Sqrt(lNumber); lIterator += 2)
                {
                    if (lNumber % lIterator == 0)
                    {
                        bResult = false;
                        break;
                    }
                }
            }

            return bResult;
        }

        static void Main(string[] args)
        {
            double lCount = 0;
            double dIterator = 1;
            double dSum = 0;

            do
            {
                if (dIterator > 2)
                {
                    dIterator += 2;
                }
                else
                {
                    dIterator++;
                }
                if(IsPrime(dIterator))
                {
                    lCount++;
                    dSum += dIterator;
                }


            } while (dIterator < 2000000);

            Console.WriteLine("Sum of 2,000,000 Primes: " + dSum);
            Console.ReadLine();

        }
    }
}
