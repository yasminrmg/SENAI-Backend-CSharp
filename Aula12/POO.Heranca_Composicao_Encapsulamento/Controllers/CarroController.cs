using System;
using POO.Heranca_Composicao_Encapsulamento.Models;

namespace POO.Heranca_Composicao_Encapsulamento.Controllers
{
    public class CarroController
    {
        CarroModel carro = new CarroModel();
        MotorModel motor = new MotorModel();

        public void ligar(){
            carro.ligado = true;
            System.Console.WriteLine("Ligando Carro!");
        }

        public void desligar(){
            carro.ligado = false;
            System.Console.WriteLine("Desligando carro...");
        }

        public void acelerar(){
            if (carro.ligado){
                System.Console.WriteLine("Carro acelerando");
            }else{
                System.Console.WriteLine("Impossível acelerar o carro pois o mesmo não esta ligado");
            }

        }

        public void Freiar(){
            if (carro.ligado==true)
            {
                System.Console.WriteLine("Carro freando");
            }else{
                System.Console.WriteLine("O carro esta desligado! Impossível frear");
            }
        }

        public void cadastrarMotor(){
            System.Console.WriteLine("Insira quantos cavalos tem o motor:");
            motor.cavalos = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Insira quantos cilindros tem o carro:");
            motor.cilindros = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o modelo do pistão do carro");
            motor.pistao = Console.ReadLine();
        }
    }
}