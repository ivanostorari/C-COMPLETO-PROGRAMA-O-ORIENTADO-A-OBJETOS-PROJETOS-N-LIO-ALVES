using System;
using tabuleiro;

namespace Projeto_Xadrez_Curso_Nelio_Aula1620
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
           
            Tela.imprimirTabuleiro(tab);
            
            Console.ReadLine();

        }
    }
}


