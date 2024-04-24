namespace Abnoan.Heranca
{
    // Classe abstrata para funcionários, derivada de MembroDaInstituicao.
    public abstract class Funcionario : MembroDaInstituicao
    {
        public int IdFuncionario { get; set; }

        // Construtor para funcionários, inclui ID do funcionário.
        public Funcionario(string nome, int idFuncionario) : base(nome)
        {
            IdFuncionario = idFuncionario;
        }

        // Método abstrato que deve ser implementado pelas subclasses de Funcionario.
        public abstract void DescreverFuncao();
    }
}