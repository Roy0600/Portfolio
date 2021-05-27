using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool spelen = true;
            int aantalkeer = 0;
            int Getal = 0;

            // zolang je wilt spelen
            while (spelen)
            {
                aantalkeer = 0;
                int laagste = 0;
                int hoogste = 100;
                int radencomputer = 1;
                Console.WriteLine("typ je getal:\n");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out Getal))
                {
                    Console.WriteLine("Dat is geen getal");
                }
                else if (Getal > 100 || Getal < 0)
                {
                    Console.WriteLine("Dat is geen goede invoer");
                }
                else
                {
                    // net zolang raden tot het goed is
                    while (Getal != radencomputer)
                    {
                        Random Willekeur = new Random();
                        radencomputer = Willekeur.Next(laagste, hoogste);
                        Console.WriteLine("De Computer gaat nu raden...");
                        Console.WriteLine("DeDomputer dacht dat je getal {0} was", radencomputer);
                        if (radencomputer < Getal)
                        {
                            laagste = radencomputer + 1;
                            aantalkeer++;
                        }
                        else if (radencomputer > Getal)
                        {
                            hoogste = radencomputer - 1;
                            aantalkeer++;
                        }
                    }

                    // ... hier is het dus geraden
                    Console.WriteLine("De Computer Raadde je getal in {0} keer", aantalkeer);
                }
                Console.WriteLine("Wil je nog een keer spelen ja/nee");

                string spel = Console.ReadLine();
                // convert input naar wat je wilt
                // zet input om naar lowercase
                
                spel = spel.ToLower();
                if ( spel =="j"||spel=="ja" )
                {
                    spelen = true;
                    Console.Clear();
                    aantalkeer = 0;
                }
                else
                {
                    spelen = false;
                    Console.WriteLine("druk op een toets om af te sluiten");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}

        
