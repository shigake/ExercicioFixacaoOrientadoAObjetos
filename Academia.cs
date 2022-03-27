using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Academia
    {
        public void Treinar(Pessoa pessoa)
        {
            pessoa.Level++;
            pessoa.Peso = pessoa.Peso - 1;
        }

        public void TreinarHeroi(Heroi heroi)
        {
            heroi.Level += 2;
        }

        public void TreinarComum(Comum latinha)
        {
            latinha.Level += 1;
        }

        public void TreinoForte(Pessoa pessoa)
        {
            pessoa.Level += 3;
        }
        
        public int Level(Pessoa pessoa)
        {
            return pessoa.Level;
        }

        public int SimuladorTreinoForte(Pessoa pessoa) {
            var levelAposTreino = pessoa.Level + 3;
            return levelAposTreino;
        }


    }
}
