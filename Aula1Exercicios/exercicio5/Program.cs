using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeFunc;
            double salario, totVendas, totReceber;
            
            Console.WriteLine("Digite nome do vendedor");
            nomeFunc = Console.ReadLine();

            Console.WriteLine("Informe salario");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe valor total de vendas");
            totVendas = double.Parse(Console.ReadLine());

            totReceber = salario + (totVendas*0.10);
            
            Console.WriteLine("Vendedor nome: " + nomeFunc + "/n Salario: "+salario);
            Console.WriteLine("O valor total a receber é: "+totReceber);
        }
    }
}
