using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleTriangleNumbers
{
    class Program
    {
        static long GetNthTriangleNumber(long lNumber)
        {
            long lResult = 0;

            for(long lIterator = 1; lIterator <= lNumber; lIterator++)
            {
                lResult = lResult + lIterator;
            }

            return lResult;
        }

        static List<long> GetFactors(long lNumber)
        {
            List<long> list = new List<long>();
            double dUpper = lNumber / 2 + 1;
            for(long lIter = 1; lIter <= dUpper; lIter++)
            {
                if(lNumber % lIter == 0)
                {
                    if(list.Contains(lIter))
                    {
                        // We have found all the factors;
                        break;
                    }
                    list.Add(lIter);
                    list.Add(lNumber/lIter);
                }
            }

            return list;
        }

        static void Main(string[] args)
        {
            bool bResult = false;
            long lIter = 1;
            do
            {
                long lTriangleNumber = GetNthTriangleNumber(lIter);
                List<long> FactorList = GetFactors(lTriangleNumber);

                long lFactors = FactorList.Count;

                if (lFactors > 500)
                {
                    Console.WriteLine("Over 500 Factors: " + lTriangleNumber);
                    bResult = true;
                }

                lIter++;
            } while (bResult != true);

            Console.ReadLine();
        }
    }
}
