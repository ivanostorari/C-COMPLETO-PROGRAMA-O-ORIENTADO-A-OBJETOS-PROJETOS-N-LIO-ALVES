using System;
using System.Globalization;

namespace CursoNelioAula8912
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);



            Console.WriteLine(d1);
        }
    }
}





