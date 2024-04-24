using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Abstract
{
    public class Cachorro : Animal
    {
        // Implementação específica para cachorro do método abstrato EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("Au au");
        }

        // Sobrescrita do método Comer para especificar o tipo de comida para cachorros
        public override void Comer()
        {
            Console.WriteLine("Estou comendo ração de cachorro");
        }
    }
}