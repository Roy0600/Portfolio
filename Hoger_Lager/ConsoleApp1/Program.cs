using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogerLager
{
    class Program
    {
        static void Main(string[] args)
        {
            int spelen = 0;
            int aantalkeer = 0;
            while (spelen == 0) {
                int Getal = 0;
                int Raden = 0;
                Random Willekeur = new Random();
                Raden = Willekeur.Next(100);
                while (Getal!=Raden)
                { 
                    Console.WriteLine("Raad het getal tussen de 1 en de 100");
                    string input = Console.ReadLine();
                        if (!int.TryParse(input, out Getal))
                        {
                            Console.WriteLine("Dat is geen getal");
                        }
                        else if (Getal > 101 || Getal < 0)
                        {
                            Console.WriteLine("Dat is geen goede invoer");
                        }
                        else
                        {
                            if (Getal > Raden)
                            {
                                Console.WriteLine("Het getal is te hoog");
                            aantalkeer++;
                            }
                            else if (Getal < Raden)
                            {
                                Console.WriteLine("Het getal is te laag");
                            aantalkeer++;
                            }
                            else
                            {
                                Console.WriteLine("goed ");
                            aantalkeer++;
                                Console.WriteLine("je hebt het in {0} keer geraden", aantalkeer);

                            }
 
                        }
                    }
                Console.WriteLine("Wil je nog een keer spelen ja/nee");
                string spel = Console.ReadLine();
                if (spel == "ja" || spel == "Ja" || spel == "JA"||spel=="j"||spel=="J")
                {
                    spelen = 0;
                    Console.Clear();
                    aantalkeer = 0 ;
                }
                else{
                    spelen = 1;
                    Console.WriteLine("druk op een toets om af te sluiten");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
