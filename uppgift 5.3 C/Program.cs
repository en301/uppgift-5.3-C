using System;

namespace uppgift_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4] {"Vad heter Love?", "Vad heter huvudstaden i Norge?", "Var kommer isak ifrån?", "Vad heter Markus?"};
            string[] svar = new string[4] { "Love", "Oslo", "Sverige", "Markus" };

            Console.WriteLine("Välj mellan fråga 1-4");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine(frågor[tal-1]);
            string frågesvar = Console.ReadLine();

            if (frågesvar == svar[tal-1])
            {
                Console.WriteLine("Du hade rätt!!");
            }
            else
            {
                Console.WriteLine("Fel, rätt svar var " + svar[tal-1]);
            }
            Console.ReadKey();
        }
    }
}
