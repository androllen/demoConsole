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
            var _bubble = bubblesort(array);
            Console.WriteLine(string.Join(',', _bubble));
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

    }
}
