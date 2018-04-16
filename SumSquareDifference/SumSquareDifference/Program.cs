using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        static long SumoftheSquares(long lMax)
        {
            long lResult = 0;
            for(long l = 1; l<=lMax; l++)
            {
                lResult += l * l;
            }

            return lResult;
        }

        static long SquareoftheSums(long lMax)
        {
            long lResult = 0;

            for (long l = 1; l<=lMax; l++)
            {
                lResult += l;
            }

            lResult = lResult * lResult;

            return lResult;
        }

        static void Main(string[] args)
        {
            long lSumofSquares = 0;
            long lSquareofSums = 0;

            lSumofSquares = SumoftheSquares(100);
            lSquareofSums = SquareoftheSums(100);

            Console.WriteLine("Sum of Squares to 100: " + lSumofSquares);
            Console.WriteLine("\n Square of the Sums to 100: " + lSquareofSums);

            Console.WriteLine("\n\n Difference: " + (lSquareofSums - lSumofSquares));

            Console.ReadLine();

        }
    }
}
