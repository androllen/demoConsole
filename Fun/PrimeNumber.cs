using System;
using System.Diagnostics;
//素数，又称质数，即整数在一个大于1的自然数中，除了1和此整数自身外，没法被其他自然数整除的数。

namespace demoConsole
{
    public class PrimeNumber
    {
        public PrimeNumber()
        {
            int i ,j=0;
            for (j = 3; j <= 1000; j += 2) //不遍历偶数，除了2偶数都不是质数
            {
                for (i = 2; i <= Math.Sqrt(j); i++) //实际遍历到此数的平方根就够了
                {
                    if (j % i == 0)
                    {
                        break;
                    }
                }
                if (i > Math.Sqrt(j))
                {
                    Debug.Write($"{j} ");
                }
            }
        }
    }
}