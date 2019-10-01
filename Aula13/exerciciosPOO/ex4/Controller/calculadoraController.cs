using System;
using ex4.Model;

namespace ex4.Controller
{
    public class calculadoraController
    {
        CalculadoraModel calculadora = new CalculadoraModel();
        
        public void calculadoraBasica(){
            System.Console.WriteLine("Informe numero a ser calculado");
            calculadora.num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite qual operação você deseja realizar\n Soma = +\nSubtração = -\nDivisão = /\nMultiplicação = *");
            calculadora.operacao = char.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o segundo numero a ser calculado");
            calculadora.num2 = double.Parse(Console.ReadLine());

            //System.Console.WriteLine(realizarCalculo());
        }

        public double realizarCalculo(){
            double resultado = 0;

            switch (calculadora.operacao){
                case '+':
                    resultado = calculadora.num1+calculadora.num2;
                    break;
                case '-':
                    resultado = calculadora.num1-calculadora.num2;
                    break;
                case '/':
                    resultado = calculadora.num1/calculadora.num2;
                    break;
                case '*':
                    resultado = calculadora.num1*calculadora.num2;
                    break;
            }

            return resultado;
        }

    }
}