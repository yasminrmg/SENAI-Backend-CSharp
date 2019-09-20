using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntFuncionarios;
            float somaSalarios =0;

            Console.WriteLine("Informe quantos funcionários você tem: ");
            qntFuncionarios = int.Parse(Console.ReadLine());

            for(int i=1; i<= qntFuncionarios; i++){
                float salario;

                Console.WriteLine("Informe o salario do funcionario: "+ i);
                salario = float.Parse(Console.ReadLine());

                somaSalarios += salario;
            }

            Console.WriteLine("A media dos salarios é " + somaSalarios/qntFuncionarios);
        }
    }
}
