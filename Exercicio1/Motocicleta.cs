using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Exercicio1
{
    public class Motocicleta : Veiculo
    {
        // Atributo privado específico para Motocicleta
        private int cilindrada;

        // Construtor da classe Motocicleta
        public Motocicleta(string marca, string modelo, int ano, int cilindrada)
            : base(marca, modelo, ano)
        {
            this.cilindrada = cilindrada;
        }

        // Getter e Setter para Cilindrada
        public int Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
    }
}