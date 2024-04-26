
namespace MediaGeralPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Titulo do Programa & Leitura da quantidade de alunos
            Console.Title = "Média Geral dos Alunos";

            Console.Write("Quantos Alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());
            
            // Quebra de Linha
            Console.WriteLine(); 
            
            // Array dos Numero de alunos
            Aluno[] alunos = new Aluno[nAlunos];

            // for que coleta a entrada de dados dos alunos (nomes, provas e notas)
            for (int i = 0; i < alunos.Length; i++)
            {
                // Entrada do nome dos alunos & nome das provas
                Console.Clear();
                Console.Write("Aluno #" + (i + 1) + " Nome..: ");
                string nome = Console.ReadLine();

                Console.Write("Aluno #" + (i + 1) + " Provas..: ");
                int provas = int.Parse(Console.ReadLine());

                // Obejto aluno atribuido ao array
                // Aluno aluno = new Aluno(nome, provas);
                // alunos[i] = aluno;
                alunos[i] = new Aluno(nome, provas);
                
                // Entrada das notas do aluno com o método "InserirNotas()"
                Console.WriteLine("Insira as notas do aluno " + nome + ".");
                alunos[i].InserirNotas();
            }
            Console.Clear();

            double mediaGeral = 0;

            // foreach que mostra saida dos dados dos alunos
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Média: " + aluno.Media);
                Console.WriteLine();

                mediaGeral += aluno.Media;
            }

            // Resultado da média geral de todos alunos
            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Média Geral dos alunos: " + resultadoFinal);


            Console.ReadKey(); 
        }
    }
}
