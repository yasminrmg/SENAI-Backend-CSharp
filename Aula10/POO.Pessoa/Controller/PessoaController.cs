using System;
using POO.Pessoa.Model;

namespace POO.Pessoa.Controller
{
    public class PessoaController
    {
        PessoaModel pessoa = new PessoaModel();

        public void recebeInformacoesPessoa (){
            System.Console.WriteLine("Informe seu nome:");
            pessoa.nome = Console.ReadLine();
            
            System.Console.WriteLine("Informe Idade:");
            pessoa.idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o peso:");
            pessoa.peso = float.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Informe a altura:");
            pessoa.altura = float.Parse(Console.ReadLine());
        }
        public void escreveInformacoesPessoa (){
            System.Console.WriteLine(pessoa.nome);
            System.Console.WriteLine(pessoa.idade);
            System.Console.WriteLine(pessoa.peso);
            System.Console.WriteLine(pessoa.altura);
            System.Console.WriteLine("O IMC é "+IMC());
        }

        public double IMC(){
            double resultado;

            resultado = pessoa.peso/Math.Pow(pessoa.altura, 2);

            return resultado;
        }
    }
}