using System;
using System.Collections.Generic;

namespace Message_Right
{
    public class Movimentacao
    {
        private List<String> movimentos = new List<String>() { "1 Deitar", "2 Sentar", "3 Passear", "4 Tomar sol" };

       
        public void EscolherMov()
        {
            Console.WriteLine("O que deseja fazer?");
            Movimentar();
            int mov = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Quero " +EscolherMovimento(mov));
        }
        public void Movimentar()
        {
            foreach (String item in movimentos)
            {
                Console.WriteLine(item);
            }
        }
        public String EscolherMovimento(int escolha)
        {
            String mov;
            switch (escolha)               
            {
                case 1:
                    mov = "Deitar"; 
                    break;
                case 2:
                    mov = "Sentar";
                    break;
                case 3:
                    mov = "Passear";
                    break;
                default:
                    mov = "Tomar sol";
                    break;
            }
            return mov;
        }
            
    }
}