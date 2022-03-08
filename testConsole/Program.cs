using DateTest;
using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TryParseExactClass tryParseExactClass = new TryParseExactClass();
            var xx= tryParseExactClass.getDate("10/10/2020");
           Console.WriteLine(xx);
            Console.WriteLine("Hello World!");
        }
    }
}
