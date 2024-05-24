using System;
using System.Collections.Generic;

namespace CursoNelioAula771
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
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
