using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] v3 = new int[10];

            for(int i=0; i<10; i++){
                Console.WriteLine("informe o "+(i+1)+"° valor do 1° vetor");
                v1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("informe o "+(i+1)+"° valor do 2° vetor");
                v2[i] = int.Parse(Console.ReadLine());

                v3[i] = (v1[i]+v2[i]);
            }

            foreach(int i in v3){
                Console.WriteLine(i);
            }
            
        }
    }
}
