using System;
using System.Collections.Generic;
using System.Text;

namespace Message_Right
{
    class Necessidades
    {
        public String Alimentacao { get; set; }
        public String  Movimentacao { get; set; }
        public String Lazer { get; set; }
        public String NecessidadeFisiologica { get; set; }

        public Necessidades(string alimentacao, string movimentacao, string lazer, string necessidadeFisiologica)
        {
            Alimentacao = alimentacao;
            Movimentacao = movimentacao;
            Lazer = lazer;
            NecessidadeFisiologica = necessidadeFisiologica;
        }

        public Necessidades()
        {
        }
        public void PerguntaNecessidade()
        {
            Console.WriteLine("Como posso ajuda Você? ");
        }
    }
        
}
