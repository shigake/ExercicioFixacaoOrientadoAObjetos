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
        public Comum(string nome, decimal peso, int level)
            : base(nome, peso, level)
        {

        }
        
        public string Profissao { get; set; }

        public string RetornaProfissao(Comum comum) 
        { 
            return comum.Profissao;
        }

        public string RetornaProfissao()
        {
            return Profissao;
        }

        public string RetornaProfissao(string nome)
        {
            return nome;
        }

    }
}
