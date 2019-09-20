using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Informe um numero decimal");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("multiplos de 3");

            for(int i=0; i<=num; i++){
                if (i%5 == 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
