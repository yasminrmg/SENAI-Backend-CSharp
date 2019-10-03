namespace ExercicioHeroi.Model
{
    public class LutaModel
    {
        public int rodada{get;set;}
        private JogadorModel jogador1{get;set;}
        private JogadorModel jogador2{get;set;}
        public int nFaltadaRodada{get;set;}
        public int ganhadorDaRodadaAnterior{get;set;}

        // public string heroiLargada {get;set;}
        // public int numRound{get;set;}

        public void proximoJogador(JogadorModel jogAtual){
            if(jogAtual.tipoJogador == 1){
                proximoAJogar = 2;
            }
        }

    }
}