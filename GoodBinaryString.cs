using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryStrings
{
    public class GoodBinaryString
    {
       public  bool CheckBinaryString(string binaryString)
        {
            // Check if string length is even (equal number of 0's and 1's)
            if (binaryString.Length % 2 != 0)
            {
                return false;
            }

            int onesCount = 0;
            int zerosCount = 0;

            foreach (char c in binaryString)
            {
                if (c == '1')
                {
                    onesCount++;
                }
                else if (c == '0')
                {
                    zerosCount++;
                }
                else
                {
                    // Invalid character
                    return false;
                }

                // Check prefix condition
                if (onesCount < zerosCount)
                {
                    return false;
                }
            }

            // All conditions met
            return true;

        }
    }
}
