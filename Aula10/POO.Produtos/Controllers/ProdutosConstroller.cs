

using POO.Produtos.Model;
using System;
using System.IO;

namespace POO.Produtos.Controllers
{
    public class ProdutosConstroller
    {
        ProdutosModel produto = new ProdutosModel();
        public void cadastrarProduto(){
            try{
                Console.WriteLine("Digite o ID do Produto:");
                produto.IdProduto = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do produto:");
                produto.NomeProduto = Console.ReadLine();

                Console.WriteLine("Informe a descrição do prodtuo");
                produto.Descricao = Console.ReadLine();

                Console.WriteLine("Informe o preço do produto");
                produto.Preco = double.Parse(Console.ReadLine());

                // Console.WriteLine("Digite o Id do fornecedor:");
                // produto.Fornecedor.IdFornecedor = int.Parse(Console.ReadLine());

                // Console.WriteLine("Digite o Nome do fornecedor");
                // produto.Fornecedor.NomeFornecedor = Console.ReadLine();
            }
            catch(Exception ex){
                System.Console.WriteLine("Desculpe :( Houve um erro na aplicação");
                salvarErros(ex);
            }
        }

        public void exibirProduto(){
            System.Console.WriteLine(produto.IdProduto);
            System.Console.WriteLine(produto.NomeProduto);
            System.Console.WriteLine(produto.Descricao);
            System.Console.WriteLine(produto.Preco);

            // System.Console.WriteLine(produto.Fornecedor.IdFornecedor);
            // System.Console.WriteLine(produto.Fornecedor.NomeFornecedor);
        }

        private void salvarErros(Exception ex){
            StreamWriter txt = new StreamWriter("error_log.txt", true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex +"\n");

            txt.Close();
        }
    }
}