using System;
using POO.Pessoa.Controller;

namespace POO.Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaController pessoa1 = new PessoaController();

            pessoa1.recebeInformacoesPessoa();
            pessoa1.escreveInformacoesPessoa();
        }
    }
}
