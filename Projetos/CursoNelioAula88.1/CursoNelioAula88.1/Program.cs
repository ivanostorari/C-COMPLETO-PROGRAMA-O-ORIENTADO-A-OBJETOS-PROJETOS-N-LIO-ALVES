using System;
using System.Globalization;

namespace CursoNelioAula881
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");


        }
    }
}


