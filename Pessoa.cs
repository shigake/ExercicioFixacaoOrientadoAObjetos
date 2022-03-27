using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Pessoa
    {
        public Pessoa(string nome, decimal peso, int level)
        {
            Nome = nome;
            Peso = peso;
            Level = level;
        }

        public string Nome { get; set; }
        public decimal Peso { get; set; }
        public int Level { get; set; }

        public int RetornaLevel() { 
            return Level;
        }

        public string RetornaNome()
        {
            return Nome;
        }

    }
}
