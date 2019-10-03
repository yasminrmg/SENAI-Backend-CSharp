using ExercicioHeroi.Model;
using System;

namespace ExercicioHeroi.Controller
{
    public class JogadorController
    {
        JogadorModel IronMan = new JogadorModel();
        JogadorModel CapitainAmerica = new JogadorModel();
        public void mostrarInformacoes(){
            
        }

        public void movimentoJogo(){
            ConsoleKeyInfo acaoAtual;
            bool AtaqueSucesso;

            if(!IronMan.ultimoMovimento){
                ConsoleColor.Red;
            }else{
                ConsoleColor.Blue;
            }

            System.Console.WriteLine("_____Jogada "+(!IronMan.ultimoMovimento?IronMan.nomeJogador:CapitainAmerica.nomeJogador)+"_____");
            System.Console.WriteLine("O que você vai fazer de SUPER AGORA?");
            acaoAtual = System.Console.ReadKey();
            

            if(!IronMan.ultimoMovimento){
                switch (acaoAtual.Key.ToString()){
                    case "c":
                        IronMan.ultimoMovimento = "Pular";
                        break;
                    case "v":
                        IronMan.ultimoMovimento = "voar";
                        break;
                    case "b":
                        IronMan.ultimoMovimento ="Atirar";
                        break;
                }
            }else{
                switch (acaoAtual.Key.ToString()){
                    case "c":
                        CapitainAmerica.ultimoMovimento = "Pular";
                        break;
                    case "v":
                        CapitainAmerica.ultimoMovimento = "Defender-se com escudo";
                        break;
                    case "b":
                        CapitainAmerica.ultimoMovimento ="Lançar escudo";
                        break;
                }
            }
        }

        public void comparaRodada(){
            if(CapitainAmerica.rodada == IronMan.rodada && )
        }

        public void IronManAtaca(){
            System.Console.WriteLine("Informe ");
        }

        
    }
}