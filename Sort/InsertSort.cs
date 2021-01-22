using System;
using System.Collections;

namespace demoConsole
{
    public class InsertSort
    {
        public static int[] Sort(int[] array)
        {
            int[] copyArray = new int[array.Length];
            array.CopyTo(copyArray, 0);

            for (int i = 1; i < copyArray.Length; i++)
            {
                int temp = copyArray[i];

                int j = i;

                while (j > 0 && temp < copyArray[j-1])
                {
                    copyArray[j] = copyArray[j-1];
                    j--;
                }

                if (j!=i)
                {
                    copyArray[j]=temp;
                }
            }

            return copyArray;
        }
    }
}