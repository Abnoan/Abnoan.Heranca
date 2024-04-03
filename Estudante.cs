namespace Abnoan.Heranca
{
    public class Estudante : MembroDaInstituicao
    {
        public int NumeroMatricula { get; set; }

        public Estudante(string nome, int numeroMatricula) : base(nome)
        {
            NumeroMatricula = numeroMatricula;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Eu sou um estudante com a matrícula {NumeroMatricula}.");
        }
    }
}
