using System;

namespace try_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            try{
                // Escrevemos um bloco de código
                Console.WriteLine("Digite um Numero");
                numero = int.Parse(Console.ReadLine());
            }catch(Exception ex){
                // Mostramos a exceção da regra
                // Erro gerado na aplicação
                throw;
                //Console.WriteLine("Ops :( Deu ruim: Erro: "+ ex.Message);
            }
        }
    }
}
