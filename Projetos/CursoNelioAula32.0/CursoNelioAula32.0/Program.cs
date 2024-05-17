using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace CursoNelioAula320
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

        }
                   
    }

}


