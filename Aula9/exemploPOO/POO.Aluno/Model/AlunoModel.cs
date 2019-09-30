namespace POO.Aluno.Model
{
    public class AlunoModel
    {
        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string nome {get;set;}

        /// <summary>
        /// Nome do curso
        /// </summary>
        /// <value>string</value>
        public string curso {get;set;}

        /// <summary>
        /// RA do aluno/ Identificação
        /// </summary>
        /// <value>string</value>
        public string RA {get;set;}

        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value>int</value>
        public int idade {get;set;}

        /// <summary>
        /// Começar a estudar
        /// </summary>
        public void estudar(){
            Console.WriteLine("Estou estudando");
        }

        /// <summary>
        /// Pede café para o professor
        /// </summary>
        public void pepdirIntervalo(){
            System.Console.WriteLine("Pode fazer intervalo aeee!");
            System.Console.WriteLine("QUERO CAFÉÉÉÉ!!");
        }

        /// <summary>
        /// Pede ajuda
        /// </summary>
        public void pedirAjuda(){
            System.Console.WriteLine("Ô Paulo, chega aê!");
        }

        public void cadastrarAluno(){
            System.Console.WriteLine("Insira seu nome");
            this.nome = Console.ReadLine();
            
            System.Console.WriteLine("Insira o nome do seu curso");
            this.curso = Console.ReadLine();
            
            System.Console.WriteLine("Insira seu RA");
            this.ra = Console.ReadLine();
            
            System.Console.WriteLine("Insira sua idade");
            this.idade = int.Parse(Console.ReadLine());
        }

        public void exibirALuno(){
            System.Console.WriteLine("Nome: "+ this.nome);
            System.Console.WriteLine("Curso: "+ this.curso);
            System.Console.WriteLine("RA: "+ this.RA);
            System.Console.WriteLine("Idade: "+ this.idade);
        }
                
    }
}