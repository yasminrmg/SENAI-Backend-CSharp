using System;
using POO.Heranca_Composicao_Encapsulamento.Controllers;
using POO.Heranca_Composicao_Encapsulamento.Models;

namespace POO.Heranca_Composicao_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroController carro = new CarroController();
            CarroEletricoController carro2 = new CarroEletricoController();

            Console.Clear();//Limpa a tela do terminal
            
            carro2.ligar();
            carro2.CarregarBateria(100);
            carro2.CarregarBateria(15);
            System.Console.WriteLine("carga do carro: "+ carro2.statusBateria());

            

            //carro2


        }
    }
}
