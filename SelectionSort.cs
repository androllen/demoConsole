using System;

namespace demoConsole
{
    public class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            int[] copyArray= new int[array.Length];
            Array.Copy(array,copyArray,array.Length);
            // 总共要经过 N-1 轮比较
            for (int i = 0; i < copyArray.Length - 1; i++)
            {
                int min = i;

                // 每轮需要比较的次数 N-i
                for (int j = i + 1; j < copyArray.Length; j++)
                {
                    if (copyArray[j] < copyArray[min])
                    {
                        // 记录目前能找到的最小值元素的下标
                        min = j;
                    }
                }

                // 将找到的最小值和i位置所在的值进行交换
                if (i != min)
                {
                    int tmp = copyArray[i];
                    copyArray[i] = copyArray[min];
                    copyArray[min] = tmp;
                }

            }
            return copyArray;
        }
    }
}