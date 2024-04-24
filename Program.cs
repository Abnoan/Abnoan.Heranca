using Abnoan.Heranca.Exercicio1;
using Abnoan.Heranca.Exercicio2;
using Abnoan.Heranca.Exercicio3;

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
            #region Exercicio 1

            var meuCarro = new Veiculo("Toyota", "Corolla", 2022);
            Console.WriteLine($"Veiculo: {meuCarro.Marca} {meuCarro.Modelo}, Ano: {meuCarro.Ano}");

            var moto = new Motocicleta("Honda", "CB500", 2021, 500);
            Console.WriteLine($"Motocicleta: {moto.Marca} {moto.Modelo}, Ano: {moto.Ano}, Cilindrada: {moto.Cilindrada}cc");

            #endregion

            #region Exercicio 2

            var dev = new Desenvolvedor("Alice", "Desenvolvimento");
            Console.WriteLine($"Desenvolvedor: {dev.Nome}, Departamento: {dev.Departamento}");
            dev.Trabalhar();

            var meuAnalista = new Analista("Bob", "Análise");
            Console.WriteLine($"Analista: {meuAnalista.Nome}, Departamento: {meuAnalista.Departamento}");
            meuAnalista.Trabalhar();

            #endregion

            #region Exercicio 3
            Leao leao = new Leao();
            Elefante elefante = new Elefante();

            leao.EmitirSom();
            leao.Comer();

            elefante.EmitirSom();
            elefante.Comer();

            #endregion
        }
    }
}