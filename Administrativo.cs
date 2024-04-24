namespace Abnoan.Heranca
{
    // Classe concreta para administrativos, derivada de Funcionario.
    public class Administrativo : Funcionario
    {
        public string Departamento { get; set; }

        // Construtor para administrativos, inclui departamento.
        public Administrativo(string nome, int idFuncionario, string departamento) : base(nome, idFuncionario)
        {
            Departamento = departamento;
        }

        // Sobrescrita do método Apresentar com informações específicas do administrativo.
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Eu trabalho no departamento de {Departamento}.");
        }

        // Implementação do método abstrato para descrever a função do administrativo.
        public override void DescreverFuncao()
        {
            Console.WriteLine($"Como membro do departamento administrativo, gerencio operações no departamento de {Departamento}.");
        }
    }
}