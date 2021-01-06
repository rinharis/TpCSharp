using System;

namespace Tp_04_Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Console.WriteLine("Le jeu du pendu");
            string motCache = "SNAKECASE";
            int motCacheSize = motCache.Length;
            char[] cachette = new char[motCacheSize];
            int compteur = 0;
            Console.WriteLine("Nombre de tentatives ({0} ou plus):", motCacheSize);
            int tentative = Convert.ToInt32(Console.ReadLine());

            Crypte();
            Decrypte();

            void Crypte()
            {
                for (int i = 0; i < motCacheSize; i++)
                {
                    cachette[i] = '-';
                    Console.Write(cachette[i]);
                }
            }

            void Decrypte()
            {
                bool motTrouve = false;
                string result;
                do
                {
                    compteur++;
                    Console.WriteLine("\nSaisir un caractere");
                    char saisie = Char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    for (int i = 0; i < motCacheSize; i++)
                    {
                        if (saisie.Equals(motCache[i]))
                            cachette[i] = saisie;
                    }
                    result = new string(cachette);
                    Console.WriteLine(result);

                    if (result.Equals(motCache))
                        motTrouve = true;
                } while (!motTrouve && compteur < tentative);

                Console.WriteLine(motTrouve && compteur < tentative ? "Trouvé en "+compteur+" tentatives !" : "Mot non trouvé après "+compteur+" tentatives !");
            }
        }
    }
}
