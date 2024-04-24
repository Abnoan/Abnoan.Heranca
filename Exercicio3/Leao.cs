using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Exercicio3
{
    // Classe Leao derivada de Animal
    public class Leao : Animal
    {
        // Implementação específica para Leão do método abstrato EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("Roar");
        }

        // Sobrescrita do método Comer para especificar o tipo de comida para leões
        public override void Comer()
        {
            Console.WriteLine("Estou comendo carne");
        }
    }
}