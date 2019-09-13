using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int npassageiros;
            float valorTotal;

            Console.WriteLine("Informe quantos passageiros utilizaram o transporte publico");
            npassageiros = int.Parse(Console.ReadLine());

            valorTotal = npassageiros * 4.30f;
            Console.WriteLine("O valor arrecadado é: " + valorTotal);
        }
    }
}
