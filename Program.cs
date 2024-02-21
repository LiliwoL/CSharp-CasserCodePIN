using System;
using System.Threading;

namespace CasserCodePIN
{
    class Program
    {
        public static void Main(string[] args)
        {
            // start représente l'heure de démarrage du programme					
            DateTime start = DateTime.Now;

            Console.WriteLine("Début du programme");
            Console.WriteLine("Objectif: trouver le code PIN à 4 chiffres");
            Console.WriteLine("==================");

            // Génération du code PIN à trouver
            Random rnd = new Random();
            int codeSecret = rnd.Next(9999);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Code à trouver: " + codeSecret);
            Console.WriteLine("");
            Console.WriteLine("");

            bool trouve = false;
            int i = 0;
            while (i < 10000 && trouve == false)
            {
                // Affichage du code testé
                Console.Write(i + " ");

                // On peut ajouter un temps de latence
                //Thread.Sleep(1000);

                // à compléter
                // si on trouve le code PIN, il faut afficher i et interrompre la boucle
                if (i == codeSecret)
                {
                    trouve = true;
                    Console.WriteLine("");
                    Console.WriteLine("\nLe code est : " + i);
                }

                i++;
            }

            Console.WriteLine("Fin du programme");

            // durée du programme = heure de fin - heure de démarrage
            TimeSpan duree = DateTime.Now - start;
            Console.WriteLine("durée du programme : " + duree);


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }
    }
}