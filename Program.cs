using System;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Academia academia = new Academia();

            Heroi daniel = new Heroi("daniel", 50, 1, "voar", "capitao voador");
            Comum daniela = new Comum("daniela", 100, 1, "Prostituta");
            //criar um objeto novo de Heroi e Comum
            



            var levelSimulado = academia.SimuladorTreinoForte(daniel);

            if (levelSimulado > 2)
            {
                academia.TreinoForte(daniel);
            }
            else {
                academia.TreinarHeroi(daniel);
            }

            for (int i = 0; i < 5; i++)
            {
                academia.TreinarComum(daniela);
            }

            //Uma pessoa recebe o Nome, Level




            //profissão da pessoa nova




            //habilidade do heroi novo


            academia.TreinarHeroi(daniel);

            academia.Treinar(daniel);
        }


    }
}
