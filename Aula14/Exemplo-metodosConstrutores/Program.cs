using System;
using System.Collections.Generic;
using Aula14.Model;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nossa classe com o metodo construtor passando os parametros
            ProdutoModel produto = new ProdutoModel(1,"Maca", "verde", 3.5);

            Console.WriteLine(produto.nomeProduto);

            // Instanciamos nossa classe sem passar parametros utilizando recarga
            ProdutoModel produto_sobrecarga = new ProdutoModel();

            produto_sobrecarga.idProduto = 1;
            produto_sobrecarga.nomeProduto = "Melao";
            produto_sobrecarga.descricao ="Amarelo";
            produto_sobrecarga.preco = 5.50;

            // chama a lista que vai ser do objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            // Adiciona objetos instanciados e atribuidos na lista
            prod.Add(new ProdutoModel(1,"Cenoura", "Laranja", 2.30));
            prod.Add(new ProdutoModel(1,"Mamão", "Laranja", 2.30));
            prod.Add(new ProdutoModel(1,"Beterraba", "Laranja", 2.30));
            prod.Add(new ProdutoModel(1,"Pastel", "Laranja", 2.30));
            prod.Add(new ProdutoModel(1,"Caldo de cana", "Laranja", 2.30));
            prod.Add(new ProdutoModel(1,"Chuchu", "Laranja", 2.30));

            // Le os dados da lista
            foreach(ProdutoModel p in prod){
                System.Console.WriteLine(p.idProduto);
                System.Console.WriteLine(p.nomeProduto);
                System.Console.WriteLine(p.descricao);
                System.Console.WriteLine(p.preco);
                System.Console.WriteLine();
            }

            // é chamado atraves do indice um atributo especifico
            System.Console.WriteLine(prod[4].nomeProduto);
        }
    }
}
