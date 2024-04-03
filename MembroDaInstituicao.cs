namespace Abnoan.Heranca
{
    public abstract class MembroDaInstituicao
    {
        public string Nome { get; set; }

        public MembroDaInstituicao(string nome)
        {
            Nome = nome;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}.");
        }
    }
}
