using System;
using System.Diagnostics.SymbolStore;
using System.Globalization;

namespace CursoNelioAula264
{
    class Program
    {
        static void Main(string[] args)
        {

            // true
            bool c1 = 2 > 3 || 4 != 5;
            // true
            bool c2 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("-------------------------------");

            // false
            bool c3 = 10 < 5;
            // true
            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c3);
            Console.WriteLine(c4);






        }
    }
}


