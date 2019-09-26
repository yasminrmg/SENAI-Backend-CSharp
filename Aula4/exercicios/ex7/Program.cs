using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int ind = 0;
            int mValor = 0;

            for (int i=0; i<10; i++){
                Console.WriteLine("Informe o "+(i+1)+"° valor");
                v1[i] = int.Parse(Console.ReadLine());

                if(i==0){
                    ind = i;
                    mValor = v1[i];
                 }else{
                     if (v1[i] >= mValor){
                         ind = i;
                         mValor = v1[i];
                    }
                }
            }

            Console.WriteLine("O maior valor é :"+mValor+" e fica na posicao "+(ind+1));
        }
    }
}
