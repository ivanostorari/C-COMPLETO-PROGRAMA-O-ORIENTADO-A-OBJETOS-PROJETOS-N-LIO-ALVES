using CursoNelioAula732;

namespace CursoNleioAula732
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple; 
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }

    }

}
