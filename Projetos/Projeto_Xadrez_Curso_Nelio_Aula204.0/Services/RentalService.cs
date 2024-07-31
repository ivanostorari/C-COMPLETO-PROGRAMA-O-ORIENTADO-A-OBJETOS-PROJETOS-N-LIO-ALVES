using System;
using Projeto_Xadrez_Curso_Nelio_Aula2040.Entities;

namespace Projeto_Xadrez_Curso_Nelio_Aula2040.Services
{
    class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        public RentalService(double pricePerHour, double pricePerDay) 
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        } 

        public void ProcessInvoice(CarRental carRental) 
        {
        }

    }
}
