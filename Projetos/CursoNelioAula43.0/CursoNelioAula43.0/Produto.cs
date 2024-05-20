using System.Security.Cryptography.X509Certificates;

namespace CursoNelioAula40
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;


        }

    }

}
