using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0, aux2= 1;
            
            for(int i = 1; i<=20; i++){
                Console.WriteLine("aux 1 :"+ aux+ " aux2:"+aux2+ " resultado:"+ (aux2+aux));
                aux = aux2;
                aux2 += aux;

                //aux+= aux2;
                //aux3 = aux3+aux2;
                //aux2 = aux;
            }
        }
    }
}
