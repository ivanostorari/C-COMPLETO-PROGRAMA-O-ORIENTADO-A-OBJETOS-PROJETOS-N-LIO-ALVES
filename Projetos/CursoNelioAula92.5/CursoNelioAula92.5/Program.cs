﻿using System;
using System.Globalization;


namespace CursoNelioAula925
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);

            Console.WriteLine(sum);
            Console.WriteLine(dif);

        }
    }
}

