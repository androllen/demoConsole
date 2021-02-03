using System;
using System.Diagnostics;
//1 1 2 3 5 8 13 21 34...

namespace demoConsole
{
    public class Febonacci
    {
        public Febonacci()
        {
            // var num = Shell(9);
            // Debug.WriteLine(num);
        }

        public int Shell(int n)
        {
            if (n==1|| n==2)
            {
                return 1;
            }
            // else{
            //     return Shell(n - 1) + Shell(n - 2);
            // }
            return Shell(n - 1) + Shell(n - 2);
        }

        //返回到 n 的斐波那契数列
        public void Main(int args)
        {
            var lf = 0;
            var rf = 1;
            var result = 0;
            Func<int, int, int> func1 = (_lf, _rf) =>
            {
                rf = _lf + _rf;
                lf = _rf;
                return lf;
            };

            while (lf < args)
            {
                result = func1(lf, rf);
                Debug.Write($"{result} ");
            }
        }

        //定义到 n 的斐波那契数列 
        public void Febon(int args)
        {
            var lf = 0;
            var rf = 1;
            Action<int, int> func1 = (_lf, _rf) =>
            {
                Debug.Write($"{rf} ");
                rf = _lf + _rf;
                lf = _rf;
            };

            while (rf < args)
            {
                func1(lf, rf);
            }
        }
    }
}