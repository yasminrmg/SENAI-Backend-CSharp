using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[10];
            
            for(int i = 0; i<=9; i++){
                Console.WriteLine("Informe o numero "+i+":");
                valor[i] = int.Parse(Console.ReadLine());
            }

            foreach (int aux in valor){
                Console.WriteLine(aux);
            }
            Console.WriteLine("ultima posicao * 5: "+valor[9]*5);
        }
    }
}
