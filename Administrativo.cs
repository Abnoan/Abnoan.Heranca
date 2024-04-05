namespace Abnoan.Heranca
{
    public class Administrativo : Funcionario
    {
        public string Departamento { get; set; }
        public Administrativo(string nome, int idFuncionario, string departamento) : base(nome, idFuncionario)
        {
            Departamento = departamento;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Eu trabalho no departamento de {Departamento}.");
        }
    }
}