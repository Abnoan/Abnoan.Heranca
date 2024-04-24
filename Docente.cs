namespace Abnoan.Heranca
{
    // Classe concreta para docentes, derivada de Funcionario.
    public class Docente : Funcionario
    {
        public string Disciplina { get; set; }

        // Construtor para docentes, inclui disciplina.
        public Docente(string nome, int idFuncionario, string disciplina) : base(nome, idFuncionario)
        {
            Disciplina = disciplina;
        }

        // Sobrescrita do método Apresentar com informações específicas do docente.
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Eu ensino {Disciplina}.");
        }

        // Implementação do método abstrato para descrever a função do docente.
        public override void DescreverFuncao()
        {
            Console.WriteLine($"Como docente, sou responsável por ensinar a disciplina de {Disciplina}.");
        }
    }
}
