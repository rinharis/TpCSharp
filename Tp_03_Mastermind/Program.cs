using System;

namespace Tp_Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        /// <summary>
        /// Nbr de valeur correct 
        /// Nbr de position correct
        /// </summary>
        private static void Start()
        {
            Console.WriteLine("Mastermind\nTrouver les 4 caractères cachés dans l'ordre.");
            char[] charEntree = { 'R', 'G', 'B', 'R' };
            char[] saisie = new char[charEntree.Length];
            int nbCharOk, nbPositionOk, nbSaisie = 0;

            VerifieSaisie(Saisie());

            //demande de saisie des reponses
            char[] Saisie()
            {
                //on reinitialise les compteurs
                nbCharOk = 0;
                nbPositionOk = 0;
                nbSaisie++;
                Console.WriteLine("Tentative n° " + nbSaisie);
                for (int i = 0; i < charEntree.Length; i++)
                {
                    Console.Write("...en position {0} : ", i + 1);
                    saisie[i] = Char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                }
                return saisie;
            }

            //traitement de la saisie
            void VerifieSaisie(char[] saisie)
            {
                //copier charEntree pour la modifier temporairement
                string strEntree = new string(charEntree);
                for (int i = 0; i < charEntree.Length; i++)
                {
                    //recherche de positionOk
                    if (saisie[i] == charEntree[i])
                        nbPositionOk++;

                    //recherche de valeurOk
                    // a partir de l'entree, on cherche l'index d'une correspondance avec la saisie
                    int indexTrouve = strEntree.IndexOf(saisie[i], 0, strEntree.Length);
                    Console.WriteLine("Index a remplacer dans l'entree : " + indexTrouve);
                    //si on trouve une correpsondance
                    if (indexTrouve > -1)
                    {
                        //on modifie le caractere pour ne plus le rechercher
                        strEntree = strEntree.Remove(indexTrouve, 1).Insert(indexTrouve, "*");
                        nbCharOk++;
                    }
                }
                Console.WriteLine("Verification : " + strEntree);
                Resultat();
            }

            void Resultat()
            {
                if(nbCharOk < charEntree.Length || nbPositionOk < charEntree.Length)
                {
                    Console.WriteLine("\nTu as {0} caractere(s) correct(s) et {1} position(s) correcte(s) !\n", nbCharOk, nbPositionOk);
                    //Reiteration
                    VerifieSaisie(Saisie());
                }
                //Fin du jeu
                else
                    Console.WriteLine("\nFelicitations, tu as trouve en {0} essais !", nbSaisie);
            }
        }
    }
}
