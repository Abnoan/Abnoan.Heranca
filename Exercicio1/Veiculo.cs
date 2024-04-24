using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Exercicio1
{
    // Classe base Veiculo
    public class Veiculo
    {
        // Atributos privados
        private string marca;
        private string modelo;
        private int ano;

        // Construtor da classe Veiculo
        public Veiculo(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        // Getters e Setters para Marca
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        // Getters e Setters para Modelo
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        // Getters e Setters para Ano
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
    }
}