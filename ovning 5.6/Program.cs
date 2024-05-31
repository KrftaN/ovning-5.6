using System;

namespace övning_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en rad med tal separerade med asterisker (*):");
            string input = Console.ReadLine();

            string[] talSträngar = input.Split('*');

            if (talSträngar.Length < 5)
            {
                Console.WriteLine("Du måste skriva in minst 5 fyrsiffriga tal separerade med asterisker.");
                return;
            }

            long produkt = 1;

            foreach (string talSträng in talSträngar)
            {
                if (!long.TryParse(talSträng, out long tal) || tal < 1000 || tal > 9999)
                {
                    Console.WriteLine($"'{talSträng}' är inte ett fyrsiffrigt tal.");
                    return;
                }

                produkt *= tal;
            }

            Console.WriteLine($"Produkten av talen är: {produkt}");
        }
    }
}
