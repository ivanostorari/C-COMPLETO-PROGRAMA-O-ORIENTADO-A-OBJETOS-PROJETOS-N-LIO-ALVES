using System;
using System.IO;

namespace Projeto_Xadrez_Curso_Nelio_Aula1970
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = 
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
