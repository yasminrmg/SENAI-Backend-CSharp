using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, totVendas, totReceber;
            
            Console.WriteLine("Informe salario");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe valor total de vendas");
            totVendas = double.Parse(Console.ReadLine());

            totReceber = salario + (totVendas*0.05);
            
            Console.WriteLine("O valor total a receber é: "+totReceber);
        }
    }
}
