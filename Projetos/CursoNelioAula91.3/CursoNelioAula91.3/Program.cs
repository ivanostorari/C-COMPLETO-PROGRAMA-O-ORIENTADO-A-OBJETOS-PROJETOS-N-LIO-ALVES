using System;
using System.Globalization;

namespace CursoNelioAula913
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d.ToLongDateString());

        }
    }
}




