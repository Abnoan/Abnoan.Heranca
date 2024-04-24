using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Abstract
{
    public abstract class Animal
    {
        // Exemplo de Método Abstrato
        public abstract void EmitirSom();

        // Exemplo de Método Concreto
        public void Respirar()
        {
            Console.WriteLine("Estou respirando");
        }

        // Exemplo de Método Virtual substituído por Comer
        public virtual void Comer()
        {
            Console.WriteLine("Estou comendo comida genérica");
        }
    }
}