using System;
using System.Globalization;

namespace CursoNelioAula914
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            string s1 = d.ToLongDateString();

            Console.WriteLine(d.ToLongDateString());


        }
    }
}




