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
            Random rnd = new Random();
            int codeSecret = rnd.Next(9999);
            bool trouve = false;
            // compteur de boucle
            int i = 0;
            while (i < 10000 && trouve == false)
            {
                Console.Write(i + " ");
                // si on trouve le code PIN, il faut afficher i et interrompre la boucle
                // A COMPLETER...
                if (i == codeSecret)
                {
                    trouve = true;
                    Console.WriteLine("Le code bon est :" +codeSecret);
                }
                Thread.Sleep(5);
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
