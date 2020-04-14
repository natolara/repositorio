using System;
using System.Collections.Generic;

namespace Message_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            Necessidades necessidades = new Necessidades("Alimentação", "Lazer", " Movimentação", " Necessidades fisiologicas");
            necessidades.PerguntaNecessidade();
            Console.WriteLine(necessidades.Alimentacao+"| |"+necessidades.Lazer+"| |"+necessidades.Movimentacao+"| |"+necessidades.NecessidadeFisiologica);
            String escolha = Console.ReadLine();
            if (escolha == necessidades.Alimentacao)
            {
                Alimentacao alimentacao = new Alimentacao("Comida", "Bebida");
                alimentacao.EscolherTipo();
            }
            if (escolha == "Movimentação")
            {
                Movimentacao movimentacao = new Movimentacao();
                movimentacao.EscolherMov();

            }
            if (escolha == "Lazer")
            {
                Lazer lazer = new Lazer();
                lazer.EscolherLazer();
            }
            if (escolha == "Necessidades fisiologicas")
            {
                NecessidadeFisiologica necFis = new NecessidadeFisiologica();
                necFis.EscolherNecessidades();
            }
            
            Console.ReadKey();

        }

    }  
}
