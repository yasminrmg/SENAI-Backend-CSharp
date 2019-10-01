using System;
using ex3.Model;

namespace ex3.Controller
{
    public class produtoController
    {
        ProdutoModel produto = new ProdutoModel();
        public void novoProduto(){
            System.Console.WriteLine("Informe o nome do Produto:");
            produto.nomeProduto = Console.ReadLine();
            
            System.Console.WriteLine("Informe o codigo do produto");
            produto.codigoProduto = Console.ReadLine();

            System.Console.WriteLine("Digite a descrição do produto");
            produto.descricaoProduto = Console.ReadLine();
            
            System.Console.WriteLine("Deseja reservar produto? Sim/Não");
            produto.reserva = Console.ReadLine()=="sim"? true : false;
        }

        public void status(){
            System.Console.WriteLine();
            System.Console.WriteLine("Nome produto: "+produto.nomeProduto);
            System.Console.WriteLine("Descrição: "+ produto.descricaoProduto);
            System.Console.WriteLine("Codigo: "+ produto.codigoProduto);
            System.Console.WriteLine("Produto reservado? "+produto.reserva);
        }
    }
}