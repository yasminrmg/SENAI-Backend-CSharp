using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, divida, restoSalario;

            Console.WriteLine("Informe seu salario");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total de suas dívidas");
            divida = float.Parse(Console.ReadLine());

            restoSalario = salario - divida;

            Console.WriteLine("O que sobrou do salario"+ restoSalario);
        }
    }
}
