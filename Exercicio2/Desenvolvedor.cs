using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Exercicio2
{
    // Classe Desenvolvedor derivada de Funcionario
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, string departamento)
            : base(nome, departamento)
        {
        }

        // Implementação específica do método Trabalhar para Desenvolvedor
        public override void Trabalhar()
        {
            Console.WriteLine("Desenvolvendo software");
        }
    }
}