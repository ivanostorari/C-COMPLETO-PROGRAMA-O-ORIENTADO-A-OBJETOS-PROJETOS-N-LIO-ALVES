using System;
using System.Collections.Generic;

namespace CursoNelioAula770
{
    class Preogram
    {
        static void Main(String[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            foreach (string obj in list) 
            {
                Console.WriteLine(obj);
            }
        }
    }
}
