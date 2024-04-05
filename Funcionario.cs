namespace Abnoan.Heranca
{
    public abstract class Funcionario : MembroDaInstituicao
    {
        public int IdFuncionario { get; set; }
        public Funcionario(string nome, int idFuncionario) : base(nome)
        {
            IdFuncionario = idFuncionario;
        }
    }
}