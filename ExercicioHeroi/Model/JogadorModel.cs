namespace ExercicioHeroi.Model
{
    public class JogadorModel
    {
        public string nomeJogador{get;set;}
        public int tipoJogador{get;set;}//1 - iron 2 -america
        public int vida{get;set;}
        public string cor{get;set;}
        public string equipe{get;set;}
        public string arma{get;set;} 
        public bool protegido{get;set;}
        public bool ataque{get;set;}
        public bool fezultimoMovimento{get;set;}
        public int numJogadorDaRodada{get;set;}//exemplo 1 ou 2
        public int rodada{get;set;}
    }
}