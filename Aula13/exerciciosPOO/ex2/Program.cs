using System;
using ex2.Controller;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController celular = new CelularController();

            celular.novoCelular();
            celular.statusCelular();

            //celular.ligarCelular();
            celular.statusCelular();

            celular.enviaMensagem();
            celular.realizarLigacao();

        }
    }
}
