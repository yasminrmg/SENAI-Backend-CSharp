using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------- exercício 2 --------
            float precoMercadoria, valTotal;
            int porcentagem;

            Console.WriteLine("Informe o valor do produto");
            precoMercadoria = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual de lucro");
            porcentagem = int.Parse(Console.ReadLine());
            
            valTotal = precoMercadoria+((precoMercadoria/100 )*porcentagem);

            Console.WriteLine("O Preço final será: " + valTotal);
        }
    }
}
