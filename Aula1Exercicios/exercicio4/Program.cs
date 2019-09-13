using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorReal, valorConversao, cotacao;

            Console.WriteLine("Informe valor a ser convertido");
            valorReal = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do Dólar");
            cotacao = double.Parse(Console.ReadLine());

            valorConversao = valorReal/cotacao;

            Console.WriteLine("O valor convertido em Dolar fica "+valorConversao);
        }
    }
}
