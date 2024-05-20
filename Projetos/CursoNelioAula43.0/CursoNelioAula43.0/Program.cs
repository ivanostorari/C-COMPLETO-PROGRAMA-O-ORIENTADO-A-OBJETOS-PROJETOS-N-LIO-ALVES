namespace CursoNelioAula430
{
    class Produto
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os Dados do produto:");
          
            Console.WriteLine("Nome: ");

            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Write("Quantidade no estoque: ");
            
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: + p");

        }

    }
}
