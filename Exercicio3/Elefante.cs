using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Exercicio3
{
    // Classe Elefante derivada de Animal
    public class Elefante : Animal
    {
        // Implementação específica para Elefante do método abstrato EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("Trumpet");
        }

        // Sobrescrita do método Comer para especificar o tipo de comida para elefantes
        public override void Comer()
        {
            Console.WriteLine("Estou comendo folhas");
        }
    }
}