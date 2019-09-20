using System;

namespace exercicioArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //String i;
            String[] teste1 = new String[6];

            teste1[0]="Ruben";            
            teste1[1]="Yasmin";
            teste1[2]="Bruna";
            teste1[3]="Patty";
            teste1[4]="Lucas";
            teste1[5]="Nilson";

            foreach(String i in teste1){
                Console.WriteLine(i);
            }
        }
    }
}
