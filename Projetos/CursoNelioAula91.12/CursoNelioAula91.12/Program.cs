using System;
using System.Globalization;

namespace CursoNelioAula9112
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            DateTime d2 = d.AddHours(2);

            DateTime d3 = d.AddMinutes(3);


            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);



        }
    }
}







