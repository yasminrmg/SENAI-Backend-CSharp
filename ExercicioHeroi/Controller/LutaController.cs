using System;
using ExercicioHeroi.Model;

namespace ExercicioHeroi.Controller
{
    public class LutaController
    {
        JogadorModel jogador1 = new JogadorModel();
        JogadorModel jogador2 = new JogadorModel();
        LutaModel luta = new LutaModel();
//ainda ajustar OO direito e terminar codigo
        public void CriaPersonagem(){
            System.Console.WriteLine("Informe qual Herói é você: \n 1-Homem de Ferro \n2-Capitão América");
            jogador1.idHeroi = int.Parse(Console.ReadLine());

            if(jogador1.idHeroi == 1){
                jogador1.nomeHeroi = "Homem de Ferro";

                jogador2.idHeroi = 2;
                jogador2.nomeHeroi = "Capitão América";
            }else{
                jogador1.nomeHeroi = "Capitão América";  

                jogador2.idHeroi = 1;
                jogador2.nomeHeroi = "Homem de Ferro";
            }

            mostraInformacoesJogadores();
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

        public void defineGanhadorRodada(){
            if(luta.nFaltadaRodada>0){
                if()
            }
        }


        public void mostraInformacoesJogadores(){
            System.Console.WriteLine("Jogador 1: "+jogador1.nomeHeroi);
            System.Console.WriteLine("Jogador 2:"+jogador2.nomeHeroi);
        }

        

        
        


    }
}