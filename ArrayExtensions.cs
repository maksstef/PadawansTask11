using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            // put your code here
            if (array.Length == 0)
                throw new ArgumentException();
            else if (array == null)
                throw new ArgumentNullException();
            else if (accuracy <= 0 || accuracy >= 1)
                throw new ArgumentOutOfRangeException();
            else
            {
                double lsum = 0;
                double rsum = 0;
                int index = 0;

                for (int i = 1; i < array.Length; ++i)
                {
                    for (int r = i; r < array.Length; ++r)
                    {
                        rsum += array[r];
                    }

                    for (int l = i; l >= 0; --l)
                    {
                        lsum += array[l];
                    }

                    if (lsum == rsum || lsum + accuracy == rsum || lsum - accuracy == rsum
                        || rsum + accuracy == lsum || rsum - accuracy == lsum)
                    {
                        index = i;
                    }
                    else
                    {
                        lsum = rsum = 0;
                    }
                }
                if (index == 0)
                    return null;
                else
                    return index;
            }
        }
    }
}
