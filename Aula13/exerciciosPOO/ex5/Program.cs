using System;
using ex5.Controller;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            PedidoController pedido = new PedidoController();

            pedido.lerPedido();
            pedido.revisaoPedido();
        }
    }
}
