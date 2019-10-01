using System;
using ex5.Model;

namespace ex5.Controller
{
    public class PedidoController
    {
        PedidoModel pedido = new PedidoModel();
        
        public void lerPedido(){
            System.Console.WriteLine("Informe o nome da pizza: ");
            pedido.nome = Console.ReadLine();
            
            System.Console.WriteLine("Tipo: ");
            pedido.tipo = Console.ReadLine();
            
            System.Console.WriteLine("Tamanho:");
            pedido.tamanho = Console.ReadLine();
            
            System.Console.WriteLine("Preço: ");
            pedido.preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o endereço de entrega");
            pedido.enderecoDeEntrega = Console.ReadLine();
            
            pedido.dataPedido = DateTime.Now;
            pedido.previsaoEntrega = DateTime.Now.AddMinutes(30);
        }

        public void revisaoPedido(){
            System.Console.WriteLine("\n_________REVISÃO PEDIDO_________");
            System.Console.WriteLine("Nome pizza: "+pedido.nome);
            System.Console.WriteLine("Tipo: "+pedido.tipo);
            System.Console.WriteLine("Tamanho: "+pedido.tamanho);
            System.Console.WriteLine("Preço: "+pedido.preco);
            System.Console.WriteLine("Endereço de entrega: "+pedido.enderecoDeEntrega);
            System.Console.WriteLine("Data do pedido: "+pedido.dataPedido.ToString());
            System.Console.WriteLine("Previsão de entrega: "+pedido.previsaoEntrega.ToString());
        }
    }
}