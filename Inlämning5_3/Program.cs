using System;
namespace inlämning5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            frågor[0] = "Vad är det högsta berget i världen?";
            frågor[1] = "Vad är den längsta floden i världen?";
            frågor[2] = "Vem var den längsta personen någonsin?";
            frågor[3] = "Vad är det största landet i världen?";


            string[] svar = new string[4];
            svar[0] = "Mount Everest";
            svar[1] = "Nilen";
            svar[2] = "Robert Wadlow";
            svar[3] = "Ryssland";


            Console.WriteLine("Välj en fråga att svara på genom att ange ett tal 1-4:");

            int userSvar = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Fråga: " + frågor[userSvar]);


            Console.WriteLine("Svara på frågan:");
            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == svar[userSvar].ToLower())
            {
                Console.WriteLine("Rätt svar!");
            }
            else
            {
                Console.WriteLine("Fel svar. Det rätta svaret är. " + svar[userSvar]);
            }
        }
    }
}

