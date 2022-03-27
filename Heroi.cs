using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Heroi : Pessoa
    {
        public Heroi(string nome, decimal peso, int level,
            string habilidade, string nomeHeroi) : base(nome, peso, level)
        {
            Habilidade = habilidade;
            NomeHeroi = nomeHeroi;
        }

        public string Habilidade { get; set; }
        public string NomeHeroi { get; set; }

        public string RetornaHabilidade(Heroi heroi) {
            return heroi.Habilidade;        
        }

    }
}
