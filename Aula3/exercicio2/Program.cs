using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Informe um numero decimal");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i<=10; i++){
                Console.WriteLine(num+" X "+i+" = "+num*i);
            }
        }
    }
}
