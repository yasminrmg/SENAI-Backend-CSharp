using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 20, acum=0;

            for(int i=1; i<=aux; i++){
                int num;
                String rl;

                Console.WriteLine("Dígite o número "+i);
                rl = Console.ReadLine();

                num = int.Parse(rl);

                if (num>0){
                    Console.WriteLine("não negativo: "+ num);
                    acum+=num;
                }
            }

            Console.WriteLine("A média do n°s não negativos é:"+ acum/aux);
        }
    }
}
