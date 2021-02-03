using System;
//九九乘法

namespace demoConsole
{
    public class Nine
    {
        public Nine()
        {
            for (int x = 1; x <= 9; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    var result = (x * y).ToString().PadLeft(2, ' ');
                    Console.Write($"{x}*{y}={result} ");
                }
                Console.Write("\n");
            }            
        }
    }
}