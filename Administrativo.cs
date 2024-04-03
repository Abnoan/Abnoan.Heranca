namespace Abnoan.Heranca
{
    public class Administrativo : Funcionario
    {
        public string Departamento { get; set; }

        public Administrativo(string nome, string departamento) : base(nome)
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
