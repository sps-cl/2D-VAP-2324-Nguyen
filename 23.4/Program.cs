using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Seznam slov
        List<string> words = new List<string>();
        // Aktuální index slova
        int currentIndex = -1;

        while (true)
        {
            Console.Write("Zadejte příkaz: ");
            // Přečtení vstupu a rozdělení na příkaz a slovo
            string[] command = Console.ReadLine().Split(':');
            string action = command[0].Trim().ToLower();

            if (action == "pridat" && command.Length == 2)
            {
                // Přidání slova do seznamu
                string word = command[1].Trim();
                words.Add(word);
                // Nastavení aktuálního indexu na poslední přidané slovo
                currentIndex = words.Count - 1;
                // Vypsání přidaného slova
                Console.WriteLine(word);
            }
            else if (action == "zpet")
            {
                // Posunutí na předchozí slovo, pokud existuje
                if (currentIndex > 0)
                {
                    currentIndex--;
                }
                // Vypsání předchozího slova nebo chybové zprávy
                Console.WriteLine(currentIndex >= 0 ? words[currentIndex] : "Není žádné slovo k zobrazení.");
            }
            else if (action == "vpred")
            {
                // Posunutí na následující slovo, pokud existuje
                if (currentIndex < words.Count - 1)
                {
                    currentIndex++;
                }
                // Vypsání následujícího slova nebo chybové zprávy
                Console.WriteLine(currentIndex < words.Count ? words[currentIndex] : "Není žádné slovo k zobrazení.");
            }
            else
            {
                // Vypsání chybové zprávy při neplatném příkazu
                Console.WriteLine("Neplatný příkaz");
            }
        }
    }
}