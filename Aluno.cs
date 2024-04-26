
namespace MediaGeralPOO
{
    class Aluno
    {
        // Propiedades
        public string Nome { get; private set; }

        private double[] _notas;

        // Retorno da média do aluno
        public double Media 
        {
            get
            {
                return CalcularMedia();
            }
        }

        // Método construtor com duas variaveis e um array onde ficam as notas
        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }

        // Método que le as notas inseridas
        public void InserirNotas() 
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        // Método que faz a soma total das notas do aluno e retorna o calculo da média
        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return total / _notas.Length;
        }

    }
}
