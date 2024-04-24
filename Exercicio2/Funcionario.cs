using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Heranca.Exercicio2
{
    // Classe abstrata Funcionario
    public abstract class Funcionario
    {
        // Atributos privados
        private string nome;
        private string departamento;

        // Construtor da classe Funcionario
        protected Funcionario(string nome, string departamento)
        {
            this.nome = nome;
            this.departamento = departamento;
        }

        // Método abstrato Trabalhar
        public abstract void Trabalhar();

        // Getters e Setters para Nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Getters e Setters para Departamento
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
    }
}