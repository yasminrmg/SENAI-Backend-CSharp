using System;
using ExercicioHeroi.Model;

namespace ExercicioHeroi.Controller
{
    public class LutaController
    {
        JogadorModel jogador1 = new JogadorModel();
        JogadorModel jogador2 = new JogadorModel();
        LutaModel luta = new LutaModel();

        public void iniciaPartida(){
        }

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

        public void mostraInformacoesJogadores(){
            System.Console.WriteLine("Jogador 1: "+jogador1.nomeHeroi);
            System.Console.WriteLine("Jogador 2:"+jogador2.nomeHeroi);
        }

        public void alteraPropriedades(){
            
        }

        
        


    }
}