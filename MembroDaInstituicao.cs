namespace Abnoan.Heranca
{
    // Classe base abstrata para todos os membros da instituição.
    public abstract class MembroDaInstituicao
    {
        public string Nome { get; set; }

        // Construtor para inicializar o nome do membro.
        public MembroDaInstituicao(string nome)
        {
            Nome = nome;
        }

        // Método virtual que pode ser sobrescrito pelas subclasses.
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}.");
        }
    }
}