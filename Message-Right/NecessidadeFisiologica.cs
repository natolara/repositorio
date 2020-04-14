using System;
using System.Collections.Generic;
using System.Text;

namespace Message_Right
{
    public class NecessidadeFisiologica
    {
        
        private List<String> remedios = new List<String>() {"1 Dor de cabeça", "2 dor no corpo", "3 remedio de pressão", "4 remedio da diabetes" };

        private List<String> necessidades = new List<string>() {"1 Remedio", "2 Tomar banho", "3 urinar", "4 necessidades" };
       
        public void EscolherNecessidades()
        {
            Console.WriteLine("O que você precisa? ");
            MostrarNecessidades();
            int nec = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(EscolherNec(nec));
        }
        public void MostrarNecessidades()
        {

            //Console.WriteLine("O que precisa fazer?");
            foreach (String item in necessidades)
            {
                Console.WriteLine(item);
            }
        }
        public String EscolherNec(int escolha)
        {
            string nec;
            switch (escolha)
            {
                case 1:
                    nec = "Remedio";
                    break;
                case 2:
                    nec = "Tomar banho";
                    break;
                case 3:
                    nec = "urinar";
                    break;
                default:
                    nec = "necessidades";
                    break;
            }
            if (nec=="Remedio")
            {
                Console.WriteLine("Qual remédio necessita?");
                foreach (String item in remedios)
                {
                    Console.WriteLine(item);
                }
                int rem = int.Parse(Console.ReadLine());
                
                switch (rem)
                {                   
                    case 1:
                        nec = "Dor de cabeça";
                        break;
                    case 2:
                        nec = "Dor no corpo";
                        break;
                    case 3:
                        nec = "Remedio de pressão";
                        break;
                    default:
                        nec = "Remedio da diabetes";
                        break;
                }
                return nec;
                
            }
            return nec;
        }
        
    }
}