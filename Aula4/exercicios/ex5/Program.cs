using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];

            for(int i=0; i<10; i++){
                v1[i] = i*2;

                Console.WriteLine("Vetor posição: "+i+" - Valor :"+v1[i]);
            }
        }
    }
}
