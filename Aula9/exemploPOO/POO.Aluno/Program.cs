using System;
using AlunoModel;

namespace POO.Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cadastrando primeiro aluno
                AlunoModel aluno = new AlunoModel(); // Instanciando objeto
                aluno.cadastrarAluno();
                aluno.exibirALuno();
            #endregion

            #region Cadastrando segundo aluno
                AlunoModel aluno2 = new AlunoModel(); // Instanciando objeto
                aluno2.cadastrarAluno();
                aluno2.exibirALuno();

            #endregion
        }
    }
}
