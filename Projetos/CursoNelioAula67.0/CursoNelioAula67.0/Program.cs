using System;
using System.Drawing;

namespace CursoNelioAula660
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }

    }

}


