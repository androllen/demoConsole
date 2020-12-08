using System;
using System.Collections;

namespace demoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomArray = generateArray(15, 3, 29);
            Console.WriteLine(string.Join(',', randomArray));

            var sort = BubbleSort.Sort(randomArray);
            Console.WriteLine("Bubble Sort:" + string.Join(',', sort));

            sort = SelectionSort.Sort(randomArray);
            Console.WriteLine("Selection Sort:" + string.Join(',', sort));

            sort = InsertSort.Sort(randomArray);
            Console.WriteLine("Insert Sort:" + string.Join(',', sort));
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


    }
}
