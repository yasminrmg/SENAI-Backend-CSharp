using System;

namespace Aula1Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------- exercício 1 --------
            int num, numTriplo;
            
            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            numTriplo = num*3;

            Console.WriteLine("O tripo de " + num + " é " + numTriplo);
        }
    }
}
