using System;
using System.Diagnostics;
//闰年的定义：能被4整除但不能被100整除，或能被400整除的年份

namespace demoConsole
{
    public class Zero
    {
        public Zero()
        {
            for (int i = 1; i <= 2020; i++)
            {
                if (((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0))
                {
                    Debug.WriteLine($"{i} 是闰年");
                }
            }
         
        }
    }
}