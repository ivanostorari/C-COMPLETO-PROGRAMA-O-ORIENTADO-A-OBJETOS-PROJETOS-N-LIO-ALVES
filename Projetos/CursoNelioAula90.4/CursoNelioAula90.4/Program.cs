using System;
using System.Globalization;

namespace CursoNelioAula904
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);


        }
    }
}






