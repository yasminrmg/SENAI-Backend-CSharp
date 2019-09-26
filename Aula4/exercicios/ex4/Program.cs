using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vA = new String[15];
            String[] vB = new String[15];
            String[] vAB = new String[15];

            for(int i=0; i<15; i++){
                Console.WriteLine("Informe uma palavra");
                vA[i] = Console.ReadLine();

                Console.WriteLine("Informe uma outra palavra");
                vB[i] = Console.ReadLine();
            }

            for(int i=0; i<15; i++){
                vAB[i] = vA[i]+vB[i];
            }

            foreach(String aux in vAB){
                Console.WriteLine(aux);
            }
        }
    }
}
