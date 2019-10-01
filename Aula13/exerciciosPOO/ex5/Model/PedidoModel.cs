using System;

namespace ex5.Model
{
    public class PedidoModel : PizzaModel
    {
        public DateTime dataPedido{get;set;}
        public string enderecoDeEntrega{get;set;}
        public DateTime previsaoEntrega{get;set;}
        public PizzaModel pizzaModel{get;set;}
        
    }
}