using System;
using POO.Produtos.Controllers;

namespace POO.Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosConstroller produto1 = new ProdutosConstroller();

            produto1.cadastrarProduto();
            produto1.exibirProduto();
        }
    }
}
