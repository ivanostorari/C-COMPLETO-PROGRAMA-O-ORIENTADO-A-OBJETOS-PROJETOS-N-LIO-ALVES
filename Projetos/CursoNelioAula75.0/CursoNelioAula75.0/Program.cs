using System;
using System.Runtime.CompilerServices;

namespace CursoNelioAula750 
{
    class Preogram 
    {
        static void Main(String[] args)
        {
            string[] vect = new string[] { "Marai", "Alex", "Bob" };
            for (int i = 0; i< vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("----------------------------------");

            foreach (string obj in vect) 
            {
                Console.WriteLine(obj);
            }

        }
    }
}