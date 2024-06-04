using System;
using System.Globalization;

namespace CursoNelioAula911
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
        }
    }
}


