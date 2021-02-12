using System;

namespace P1code
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            Console.WriteLine("     Saber a idade     ");
            Console.WriteLine("#########################");
            Console.Write("Qual ano você nasceu? ");
            ano = Convert.ToInt32(Console.ReadLine());
            
            int calc = 2021 - ano;

            if (calc >= 18) 
            {
                Console.WriteLine("Você é maior de idade!");
                Console.WriteLine($"Sua idade é {calc} anos");

            }

            else 
            {
                int calc2 = 18 - calc;
                Console.WriteLine("Você é menor de idade!");
                Console.WriteLine($"Volte daqui {calc2} anos!");

            }

                Console.WriteLine("#########################");
            

        }
    }
}
