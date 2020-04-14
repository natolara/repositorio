using System;
using System.Collections.Generic;
using System.Text;

namespace Message_Right
{
    class Lazer
    {
        private List<String> lazeres = new List<string>() { "1 Assistir Tv", "2 Passear" };
    
        public void EscolherLazer()
        {
            Console.WriteLine("Qual a diversão pra hoje? ");
            OpcoesLazer();
            int laz = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Quero " + EscolherLazer(laz));
        }
        public void OpcoesLazer()
        {
            foreach (String item in lazeres)
            {
                Console.WriteLine(item);
            }
        }  

        public String EscolherLazer(int escolha)
        {
            string laz;
            switch (escolha)
            {
                case 1:
                    laz = "Assistir Tv";
                    break;
                default:
                    laz = "Passear";
                    break;
            }
            return laz;
        }
    }
}
