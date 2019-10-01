using System;
using ex1.Controller;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController aluno = new AlunoController();

            aluno.pegarInfoAluno();
            aluno.mostrarInfoAluno();
        }
    }
}
