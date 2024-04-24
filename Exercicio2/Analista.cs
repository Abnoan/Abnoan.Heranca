using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Exercicio2
{
    // Classe Analista derivada de Funcionario
    public class Analista : Funcionario
    {
        public Analista(string nome, string departamento)
            : base(nome, departamento)
        {
        }

        // Implementação específica do método Trabalhar para Analista
        public override void Trabalhar()
        {
            Console.WriteLine("Analisando dados");
        }
    }
}