using System;
using System.Globalization;

namespace CursoNelioAula922
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
        }
    }
}

