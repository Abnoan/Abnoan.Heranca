namespace Abnoan.Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MembroDaInstituicao> membros = new()
            {
                new Estudante("Abnoan", 12345),
                new Administrativo("Hector", "Financeiro"),
                new Docente("Rafael", "Matemática")
            };

            foreach (var membro in membros)
            {
                membro.Apresentar();
                Console.WriteLine();
            }
        }
    }
}