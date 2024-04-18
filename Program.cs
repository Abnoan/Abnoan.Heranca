namespace Abnoan.Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MembroDaInstituicao> membros = new()
            {
                new Estudante(nome:"Abnoan", 12345),
                new Administrativo("Hector", 123,"Financeiro"),
                new Docente("Rafael", 2456 ,"Matemática")
            };

            foreach (var membro in membros)
            {
                membro.Apresentar();
                Console.WriteLine();
            }
        }
    }
}