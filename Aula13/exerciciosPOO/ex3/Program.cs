using System;
using ex3.Controller;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            produtoController produto = new produtoController();

            produto.novoProduto();
            produto.status();
        }
    }
}
