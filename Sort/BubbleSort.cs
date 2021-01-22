using System;


namespace demoConsole
{
    public class BubbleSort
    {
        public static int[] _Sort(int[] array)
        {
            int[] copyArray = new int[array.Length];
            array.CopyTo(copyArray, 0);
            for (int i = copyArray.Length - 1; 0 < i; i--)
            {
                for (int j = i - 1; 0 <= j; j--)
                {
                    if (copyArray[j] > copyArray[i])
                    {
                        int temp = copyArray[j];
                        copyArray[j] = copyArray[i];
                        copyArray[i] = temp;
                    }
                }
            }
            return copyArray;
        }

        public static int[] Sort(int[] array)
        {
            int[] copyArray = new int[array.Length];
            array.CopyTo(copyArray, 0);
            for (int i = 1; i < copyArray.Length; i++)
            {
                for (int j = 0; j < copyArray.Length - i; j++)
                {
                    if (copyArray[j] > copyArray[j + 1])
                    {
                        int temp = copyArray[j];
                        copyArray[j] = copyArray[j + 1];
                        copyArray[j + 1] = temp;
                    }
                }
            }
            return copyArray;
        }
    }
}