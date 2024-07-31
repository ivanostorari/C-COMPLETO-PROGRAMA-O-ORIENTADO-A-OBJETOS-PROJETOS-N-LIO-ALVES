using System;
using System.Globalization;
using Projeto_Xadrez_Curso_Nelio_Aula2040.Entities;

namespace Projeto_Xadrez_Curso_Nelio_Aula2040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (ss/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (ss/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }

    }
}
