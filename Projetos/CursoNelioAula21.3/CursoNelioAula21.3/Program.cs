﻿using System;
using System.Globalization;

namespace Aula213
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10.0 / 8;

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = b * b - 4.0 * a * c;


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

        }
    }
}