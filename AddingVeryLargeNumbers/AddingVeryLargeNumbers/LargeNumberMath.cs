using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingVeryLargeNumbers
{
    /// <summary>
    /// Description:  Numbers over a certain side cannot be handled by normal math classes. 
    ///                 This is a self created class that does mathmatical manipluation through strings.
    /// </summary>
    class LargeNumberMath
    {
        public LargeNumberMath()
        {
            Console.WriteLine("LargeNumberMath Constructor\n");
        }

        /// <summary>
        /// Adding Large numbers as Strings
        /// </summary>
        /// <param name="x">Number 1</param>
        /// <param name="y">Number 2</param>
        /// <returns>Result of adding Number 1 and Number 2 as a string</returns>
        public string AddVeryLargeNumbers(string x, string y)
        {
            string strResult = "";

            var xMaxIndex = x.Length - 1;
            var yMaxIndex = y.Length - 1;
            var CarryOver = 0;
            var MaxLength = x.Length > y.Length ? x.Length : y.Length;
            
            // Loop through the strings using the longest string as the number of iterations
            for(int i = 0; i < MaxLength; i++)
            {
                var xIndex = xMaxIndex - i;
                var yIndex = yMaxIndex - i;

                // Working through the number from least significant to most.  
                // If one number is larger than the other we are filling the open spots with zeros.
                var xUnit = xIndex >= 0 ? getDigitFromXAtIndex(x, i) : 0;
                var yUnit = yIndex >= 0 ? getDigitFromXAtIndex(y, i) : 0;

                var Sum = CarryOver + xUnit + yUnit;

                // If we are not add the end of the number, we have to add the ones position and determine if there is CarryOver
                if(i < MaxLength -1)
                {
                    // The new string is the ones position of the sum + the string that has been calculated thus far
                    strResult = (Sum % 10).ToString() + strResult;
                    // If the Sum is greater than 10, then there is a CarryOver
                    CarryOver = (Sum / 10) > 0 ? 1 : 0;
                }
                else
                {
                    // If we are done, we just add the full number
                    // New Comments
                    strResult = Sum.ToString() + strResult;
                }
            }

            return strResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int getDigitFromXAtIndex(string str, int y)
        {
            return Convert.ToInt32(str[str.Length - 1 - y].ToString());
        }

    }
}
