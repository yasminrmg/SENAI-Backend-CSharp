using ex1.Model;
using System;

namespace ex1.Controller
{
    public class AlunoController
    {
        AlunoModel aluno = new AlunoModel();

        public void pegarInfoAluno(){
            try{
                System.Console.WriteLine("Informe Nome do aluno");
                aluno.nome = Console.ReadLine();

                System.Console.WriteLine("Curso");
                aluno.curso = Console.ReadLine();
                
                System.Console.WriteLine("Idade");
                aluno.idade = int.Parse(Console.ReadLine());
                

                System.Console.WriteLine("Digite o RG");
                aluno.rg = Console.ReadLine();
                
                System.Console.WriteLine("O aluno é bolsista?\n Digite Sim ou Não");
                aluno.bolsista = (Console.ReadLine() == "sim")? true: false;

            }catch(Exception ex){
                System.Console.WriteLine("Houve um erro sorry\n\n"+ex.Message);
            }
        }

        public void mostrarInfoAluno(){
            System.Console.WriteLine("\n\n");
            System.Console.WriteLine(aluno.nome);
            System.Console.WriteLine(aluno.curso);
            System.Console.WriteLine(aluno.idade);
            System.Console.WriteLine(aluno.rg);
            System.Console.WriteLine(aluno.bolsista);
        }
    }
}