using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace CursoNelioAula275
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom Dia!");
                Console.WriteLine("---------------------------------");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa Tarde!");
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
                Console.WriteLine("---------------------------------");
            } 

        }
    }
}

