using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomeProduto = new String[12];
            String[] cor = new String[12];
            String[] tamanho = new String[12];
            float[] preco = new float[12]; 

            for(int i=0; i<12; i++){
                Console.WriteLine("Informe o nome do "+(i+1)+"° produto");
                nomeProduto[i] = Console.ReadLine();

                Console.WriteLine("Informe sua cor");
                cor[i] = Console.ReadLine();

                Console.WriteLine("Informe seu tamanho");
                tamanho[i] = Console.ReadLine();

                Console.WriteLine("Informe seu preco");
                preco[i] = float.Parse(Console.ReadLine());
            }

            for(int i=0; i<12; i++){
                Console.WriteLine(nomeProduto[i]);
                Console.WriteLine(cor[i]);
                Console.WriteLine(tamanho[i]);
                Console.WriteLine(preco[i]);
                
            }

            
        }

        

    }
}
