using System;

namespace ex0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CNPJ");
            string cnpj = Console.ReadLine();

            validaCNPJ(cnpj);

            Console.WriteLine("O CNPJ é: "+validaCNPJ(cnpj));
        }

        static bool validaCNPJ(string cnpjUsuario){
            int dv1;
            int dv2;
            int calculoMultiSoma = 0;
            int resto;
            int resultado;

            int[] v1 = {5,4,3,2,9,8,7,6,5,4,3,2};
            int[] v2 = {6,5,4,3,2,9,8,7,6,5,4,3,2};

            string digVerifCNPJ;
            string partCNPJ;

            cnpjUsuario = cnpjUsuario.Replace(".","").Replace("/","").Replace("-","");

            digVerifCNPJ = cnpjUsuario.Substring(10);
            partCNPJ = cnpjUsuario.Substring(0,12);
            
            bool resultadoFinal = false;

            //Console.WriteLine(digVerifCNPJ);
            //Console.WriteLine(partCNPJ);
            //Console.WriteLine(cnpjUsuario);

            for(int i=0; i<=11; i++){
                calculoMultiSoma += int.Parse(partCNPJ[i].ToString())*v1[i];
            }

            resto = calculoMultiSoma % 11;
            resultado = calculoMultiSoma / 11;

            if(resto<2){
                dv1 = 0;
            }else{
                dv1 = 11 - resto;
            }

            calculoMultiSoma = 0;
            for(int i=0; i<=12; i++){
                calculoMultiSoma += int.Parse((partCNPJ+dv1.ToString())[i].ToString())*v2[i];
            }

            resto = calculoMultiSoma % 11;
            resultado = calculoMultiSoma / 11;
            
            if(resto<2){
                dv2 = 0;
            }else{
                dv2 = 11 - resto;
            } 

            // Console.WriteLine(resto);
            // Console.WriteLine(resultado);
            // Console.WriteLine(dv1);
            // Console.WriteLine(dv2);
            // Console.WriteLine(digVerifCNPJ);
            // Console.WriteLine(dv1.ToString()+dv2.ToString());

            if ((dv1.ToString()+dv2.ToString()) == digVerifCNPJ.Substring(2)){
                resultadoFinal = true;
            }else {
                resultadoFinal = false;
            }
            
            return resultadoFinal;
            
        }

    }
}
