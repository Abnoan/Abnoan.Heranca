using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Exercicio3
{
    // Classe abstrata base Animal
    public abstract class Animal
    {
        // Método abstrato para emitir som
        public abstract void EmitirSom();

        // Método virtual para comer
        public virtual void Comer()
        {
            Console.WriteLine("Estou comendo");
        }
    }
}