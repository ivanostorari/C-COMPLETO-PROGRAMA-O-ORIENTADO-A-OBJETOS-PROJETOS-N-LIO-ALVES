﻿using System;

namespace CursoNelioEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();  

            string s = Console.ReadLine();

            string[] v = Console.Read().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];
            

            Console.WriteLine("Vovê digitou: + frase");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}