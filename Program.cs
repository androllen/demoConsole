using System;
using System.Diagnostics;


namespace demoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var zero2 = new Febonacci();
            var num = zero2.Shell(10);
            Debug.WriteLine(num);
            zero2.Main(14);
            zero2.Febon(155);
           
        }


    }
}
