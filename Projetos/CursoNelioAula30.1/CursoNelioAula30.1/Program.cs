using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace CursoNelioAula301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior " + resultados);

            

        }
    }
}


