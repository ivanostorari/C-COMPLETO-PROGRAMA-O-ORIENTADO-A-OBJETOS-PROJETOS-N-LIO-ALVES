using System;
using System.Globalization;

namespace CursoNelioAula274
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

                if (hora >= 12 && hora < 18)
                {
                    Console.WriteLine("Boa Tarde!");
                    Console.WriteLine("---------------------------------");
                }

                if (hora >= 18)
                {
                    Console.WriteLine("Boa Noite!");
                    Console.WriteLine("---------------------------------");
                }
           }
     }
}

