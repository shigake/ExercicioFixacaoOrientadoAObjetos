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

            Heroi zecao = new Heroi("zecao", 150, 99, "super força", "zeca urubu");
            Comum monica = new Comum("monica", 60, 15, "dona da rua");


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
            var NomeHeroi = zecao.RetornaNome();
            var LevelHeroi = zecao.RetornaLevel();


            //profissão da pessoa nova
            var NovoJob = daniela.RetornaProfissao(monica);


            //habilidade do heroi novo
            var NovoHeroiHabilidade = zecao.RetornaHabilidade(zecao);


            academia.TreinarHeroi(daniel);

            academia.Treinar(daniel);
        }


    }
}
