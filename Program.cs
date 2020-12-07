using System;
using System.Collections;

namespace demoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = generateArray(15, 3, 29);
            Console.WriteLine(string.Join(',', array));
            int[] copyArr=new int[array.Length];
            array.CopyTo(copyArr,0);
            int[] copySelection = new int[array.Length];
            array.CopyTo(copySelection, 0);
           
            // var _bubble = bubblesort(array);
            // Console.WriteLine(string.Join(',', _bubble));

            var bubbleSort = _bubblesort(copyArr);
            Console.WriteLine("冒泡排序：" + string.Join(',', bubbleSort));

            var selectionSort = SelectionSort.Sort(copySelection);
            Console.WriteLine("选择排序：" + string.Join(',', selectionSort));
        }
        static int[] generateArray(int length, int mix, int max)
        {
            int[] array = new int[length];
            Hashtable table = new Hashtable();
            Random random = new Random();
            for (int i = 0; table.Count < length; i++)
            {
                var data = random.Next(mix, max);
                if (!table.ContainsKey(data) && data != 0)
                {
                    table.Add(data, data);
                    array[table.Count - 1] = data;
                }
            }
            return array;
        }
        static int[] bubblesort(int[] array)
        {
            for (int i = array.Length - 1; 0 < i; i--)
            {
                for (int j = i - 1; 0 <= j; j--)
                {
                    if (array[j] > array[i])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        static int[] _bubblesort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

    }
}
