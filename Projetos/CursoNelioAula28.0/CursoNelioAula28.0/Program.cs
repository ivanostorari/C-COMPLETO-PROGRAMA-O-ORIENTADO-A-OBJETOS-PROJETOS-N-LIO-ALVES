using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace CursoNelioAula280
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());

            if (preco > 100.0)
            {
                double desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);

        }
    }
}

