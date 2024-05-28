using System;
using System.Globalization;

namespace CursoNelioAula
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10; 
            var y = 20.0;
            var z = "Maria";

            // errado escrever dessa forma o var
            var w = z;
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}

