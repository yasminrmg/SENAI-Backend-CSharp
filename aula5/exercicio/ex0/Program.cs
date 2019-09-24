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
        }

        static bool validaCNPJ(string cnpjUsuario){
            int dv;
            int calculoMultiSoma;
            int resto;

            int[] v1 = {9,8,7,6,5,4,3,2,9,8,7,6,5};

            string digVerifCNPJ;
            string partCNPJ;

            cnpjUsuario = cnpjUsuario.Replace(".","").Replace("/","").Replace("-","");

            digVerifCNPJ = cnpjUsuario.Substring(12);
            partCNPJ = cnpjUsuario.Substring(0,12);

            //Console.WriteLine(digVerifCNPJ);
            //Console.WriteLine(partCNPJ);
            //Console.WriteLine(cnpjUsuario);

            for(int i=0; i<=12; i++){
                calcSoma += int.Parse(partCNPJ[i].ToString())*v1[i];
            }

            resto = calcSoma%11;

            Console.WriteLine(resto);
            
            return false;
            
        }

    }
}
