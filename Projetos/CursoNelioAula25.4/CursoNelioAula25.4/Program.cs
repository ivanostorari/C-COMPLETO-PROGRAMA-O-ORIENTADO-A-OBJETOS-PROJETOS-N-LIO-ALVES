using System;
using System.Globalization;

namespace CursoNelioAula235
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            bool c1 = a < 10;
            bool C2 = a < 20;
            bool C3 = a > 10;
            bool C4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(C2);
            Console.WriteLine(C3);
            Console.WriteLine(C4);
            Console.WriteLine("-------------------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10; 
            bool c8 = a != 10;


            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);




        }
    }
}


