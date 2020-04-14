using System;
using System.Collections.Generic;

namespace Message_Right
{
    public class Alimentacao
    {
        public string Comida { get; set; }
        public string Bebida { get; set; }
        static List<String> comidas = new List<string>() { "1 Refeiçao completa",
            "2 Biscoito", "3 Tomar café", "4 Fruta", "5 Bolo" };
        static List<String> bebidas = new List<string>() { "1 Agua", "2 Suco", "3 Café", "4 Chá" };

        public Alimentacao(string comida, string bebida)
        {
            Comida = comida;
            Bebida = bebida;
        }
        public Alimentacao()
        {
        }      
        
        public void EscolherTipo()
        {
            Console.WriteLine("O que deseja :" + Comida + " ou " + Bebida + "?");
            String alimento = Console.ReadLine();
            if (alimento == Comida)
            {

                Comer();
                int esc = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Desejo " + Escolha(esc));
            }
            if (alimento == Bebida)
            {

                Beber();
                int esc = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Desejo " + Escolha1(esc));
            }
        }
        public void Comer()
        {
            Console.WriteLine("O que deseja Comer: ");
            foreach (String item in comidas)
            {
                Console.WriteLine(item);
            }             
        }
        public String Escolha(int escolha)
        {
            String tipo;
            switch (escolha)
            {
                case 1:
                    tipo = "Refeição completa";
                    break;
                case 2:
                    tipo = "Biscoito";
                    break;
                case 3:
                    tipo = "Tomar café";
                    break;
                case 4:
                    tipo = "Fruta";
                    break;
                default:
                    tipo = "Bolo";
                    break;
            }
            return tipo;
        }
        public void Beber()
        {
            Console.WriteLine("O que deseja beber: ");
            foreach (String item in bebidas)
            {
                Console.WriteLine(item);
            }
        }
        public String Escolha1(int escolha)
        {
            String tipo;
            switch (escolha)
            {
                case 1:
                    tipo = "Agua";
                    break;
                case 2:
                    tipo = "Suco"; 
                    break;
                case 3:
                    tipo = "Café"; 
                    break;               
                default:
                    tipo = "Chá";
                    break;
            }
            return tipo;
        }

    }
}