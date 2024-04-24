namespace Abnoan.Heranca
{
    // Classe concreta para estudantes, derivada de MembroDaInstituicao.
    public class Estudante : MembroDaInstituicao
    {
        public int NumeroMatricula { get; set; }

        // Construtor para estudantes, inclui número de matrícula.
        public Estudante(string nome, int numeroMatricula) : base(nome)
        {
            NumeroMatricula = numeroMatricula;
        }

        // Sobrescrita do método Apresentar com informações específicas do estudante.
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Eu sou um estudante com a matrícula {NumeroMatricula}.");
        }
    }
}
