using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Comum : Pessoa
    {
        public Comum(string nome, decimal peso, int level, string profissao) 
            : base(nome, peso, level)
        {
            Profissao = profissao;
        }
        public string Profissao { get; set; }

        public string RetornaProfissao(Comum comum) { 
            return comum.Profissao;
        }
    }
}
