using System;
using System.Globalization;

namespace CursoNelioAula894
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2028, 11, 25);
            DateTime d2 = new DateTime(2028, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2028, 11, 25, 20, 45, 3, 500);

            DateTime d4 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }
    }
}


