using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int[] v2 = new int[10];

            int[] v3 = new int[20];

            for(int i = 0; i<10; i++){
                Console.WriteLine("Inoforme o "+ (i+1)+"° valor");
                v1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i<10; i++){
                Console.WriteLine("Inoforme o "+ (i+1)+"° valor");
                v2[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<10; i++){
                v3[i] = v1[i];
                v3[(i+10)] = v2[i];
            }

            for(int i=0; i<20; i++){
                Console.Write(v3[i]+", ");
            }
        }
    }
}
