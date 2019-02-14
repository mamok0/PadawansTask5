using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new ArgumentException();
            if (source.Length == 1)
                return "Yes";
            for(int i=0, j=source.Length-1; i<j; i++, j--)
            {
                if (source[i] != source[j])
                    return "No";
            }
            if (source.Length % 2 == 0)
                return "Yes";
            int centerOfArray = source.Length / 2;
            if (source[centerOfArray] == source[centerOfArray + 1] && source[centerOfArray] == source[centerOfArray - 1])
                return "Yes";
            if (source[centerOfArray] != source[centerOfArray + 1] && source[centerOfArray] != source[centerOfArray - 1])
                return "Yes";
            return "No";
            //0 1 2 3 4 5 6  
        }
    }
}
