using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1, impar=0, count=1;

            while (count<= 100){
                count++;
                impar = impar+count;
                
                if(impar%2 != 0 ){
                    num = num+1;
                    Console.WriteLine(impar);
                }
            }
            Console.WriteLine(num);
            /*
                        int aux=0;
            for(int i=1; i<=100; i++){
                if (i%2 != 0 ){
                    Console.WriteLine(i);
                    aux++;
                }
            }
            Console.WriteLine("O total de impares é "+aux);
         */

        }
    }
}
