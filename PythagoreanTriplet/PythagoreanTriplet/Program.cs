using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 2;
            double c2 =0;
            int iSum = 0;
            int iProduct = 0;
            bool bResult = false;
            bool bTooHigh = false;

            do
            {
                a += 1;
                b = a;
                bTooHigh = false;
                do
                {
                    b += 1;
                    c2 = (a * a) + (b * b);
                    c2 = Math.Sqrt(c2);
                    if (c2 % 1 == 0)
                    {
                        // We got a whole number
                        c = Convert.ToInt32(c2);
                        if (a + b + c == 1000)
                        {
                            bResult = true;
                            iProduct = a * b * c;
                        }
                        else if (a + b + c > 1000)
                        {
                            bTooHigh = true;
                        }
                    }
                    else if ( a+b+c2 > 1000)
                    {
                        bTooHigh = true;
                    }

                } while (bResult != true && bTooHigh != true );
            } while (bResult != true && a < 997);

            Console.WriteLine(iProduct);
            Console.ReadLine();

        }
    }
}
