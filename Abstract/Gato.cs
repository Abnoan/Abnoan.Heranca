using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Abstract
{
    public class Gato : Animal
    {
        // Implementação específica para gato do método abstrato EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }

        // Sobrescrita do método Comer para especificar o tipo de comida para gatos
        public override void Comer()
        {
            Console.WriteLine("Estou comendo ração de gato");
        }
    }
}