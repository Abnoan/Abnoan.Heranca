namespace Abnoan.Heranca
{
    public class Docente : Funcionario
    {
        public string Disciplina { get; set; }

        public Docente(string nome, string disciplina) : base(nome)
        {
            Disciplina = disciplina;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Eu ensino {Disciplina}.");
        }
    }
}
