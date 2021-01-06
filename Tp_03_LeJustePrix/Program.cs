using System;

namespace Tp_03_LeJustePrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Console.WriteLine("Le juste prix");
            Console.WriteLine("Saisir un nombre :");
            int intervalle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir un nombre de tentatives");
            int tentative = Convert.ToInt32(Console.ReadLine());
            Random rd = new Random();
            int reponse = rd.Next(0, intervalle + 1);
            Console.WriteLine("Trouver le juste prix entre 0 et {0} :", intervalle );
            string proposition = "";
            bool perdu = false;
            int compteur = 0;
            do
            {
                compteur++;
                if (compteur >= tentative)
                    perdu = true;
                proposition = Reponse(reponse);
                Console.WriteLine(proposition);
            } while (!String.IsNullOrEmpty(proposition) && perdu == false);
            Console.WriteLine(perdu ? "Perdu !" : "Bravo, tu as fais " + compteur + " proposition(s) !");
        }
        /// <summary>
        /// Fonction de comparaison entre la proposition de l'utilisateur et la reponse attendue
        /// </summary>
        /// <param name="reponse">Reponse attendue</param>
        /// <returns>Retourne un string moins, plus ou vide</returns>
        static string Reponse(int reponse)
        {
            int proposition = Convert.ToInt32(Console.ReadLine());
            return proposition > reponse ? "moins" : proposition < reponse ? "plus" : null;
        }


    }
}
