using System;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // chamamos nossa primeira função
            Console.WriteLine(BomDia("Boa tarde!"));

            //chamamos a função do tipo VOID (sem retorno)
            imprimeDataeHora();

            // Chamamos nossa função que calcula a media
            double[] numeros = {2, 5, 2, 8, 5, 9};
            Console.WriteLine(CalculaMedia(numeros));
        }

        /// <summary>
        /// Funcao que escreve bom dia para o usuario
        /// </summary>
        /// <returns>retorna bolm dia</returns>
        public static String BomDia(){
            return "Ola! Bom dia";
        }

        /// <summary>
        /// funcao que mostra saudacao de acordo com o horario atual
        /// </summary>
        /// <param name="saudacao">um texto quaulquer (sobrecarga de metodo)</param>
        /// <returns>saudacao de acordo com o horario</returns>
        public static String BomDia(string saudacao){
            int hora = DateTime.Now.Hour;

            if(hora < 12){
                saudacao = "Bom dia";
            }else if (hora >= 12 && hora < 18){
                saudacao = "Boa tarde";
            }else{
                saudacao = "Boa noite";
            }

            return saudacao;
        }

        /// <summary>
        /// Retorna um numero - Teste de Sobrecarga
        /// </summary>
        /// <param name="numero">Um numero inteiro qualquer</param>
        /// <returns>Numero passado como parametro</returns>
        public int BomDia(int numero){
            return numero;
        }

        /// <summary>
        /// Retorna Data e Hora atuais
        /// </summary>
        static void imprimeDataeHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour.ToString());
        }

        /// <summary>
        /// Função que calcula a media de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos vetores</returns>
        static double CalculaMedia(double[] valores){
            double resultado = 0;

            for(int i = 0; i< valores.Length; i++){
                resultado += valores[i];
            }

            resultado = resultado / valores.Length;

            return resultado;
        }

        /// <summary>
        /// Funcao que soma valor dos vetores
        /// </summary>
        /// <param name="v1">vetor com valores inteiros</param>
        /// <param name="v2">vetor com valores inteiros</param>
        /// <returns>retorna soma dos vetores</returns>
        public static int CalculaSoma(int[] v1, int[] v2){
            int resultado;

            for(int i=0; i<10; i++){
                resultado += v1[i]+v2[i];
            }

            return resultado;
        } 
        
    }
}
