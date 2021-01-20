using System;
using System.Collections.Generic;
using System.Text;

namespace _01_hello
{
    public class Tp_01
    {
        public Tp_01()
        {
            //SaisieAffichageNom();
            //Addition();
            //Addition();
            //PlusGrand();
            //ProfitPerte();
            //Jour();
            //Calculatrice();TODO
            //PairImpair();
            //VoyelleConsonne();
            //Bissextile();
            //AlphabetChiffreSymbole();
            //EscalierEtoile();
            //PyramideInclinee();

            //TODO
            //PyramideDroite();

            //BouclePrenom();
            //FizzBuzz();
            

        }

        public void SaisieAffichageNom()
        {
            Console.WriteLine("\nExercice 1 : saisie et affichage du nom");
            string welcome = "Bonjour,\nMerci de saisir ton nom :";
            Console.WriteLine(welcome);
            string name = Console.ReadLine();
            Console.WriteLine("Bienvenue " + name);
        }

        public void Addition()
        {
            Console.WriteLine("\nExercice 2 : addition de nombres entiers");
            Console.WriteLine("Saisis un nombre");
            string arg1 = Console.ReadLine();
            Console.WriteLine("\nSaisis un atre nombre");
            string arg2 = Console.ReadLine();
            int arg1f = Int32.Parse(arg1);
            int arg2f = Int32.Parse(arg2);
            int sum = arg1f + arg2f;
            Console.WriteLine(arg1 + " + " + arg2 + " = " + sum);
        }
       
        public void PlusGrand()
        {
            Console.WriteLine("\nExercice 3 : recherche du plus grand nombre");
            Console.WriteLine("\nSaisis 3 nombres entiers séparés par un espace");
            string args = Console.ReadLine();
            string[] substr = args.Split(' ');
            int[] values = new int[3];
            int max = 0;
            
            for(int i = 0; i < substr.Length; i++)
            {
                values[i] = Int32.Parse(substr[i]);
                if (i == 0)
                    max = values[i];
                else if (values[i] > max)
                    max = values[i];
                
                Console.Write(values[i] + " ");
                //si derniere valeur
                if(i == substr.Length - 1)
                    Console.Write("--> ");
                else
                    Console.Write("/ ");
            }
            Console.WriteLine(max);
        }

        public void ProfitPerte()
        {
            Console.WriteLine("\nExercice 4 : Profit ou perte");
            Console.WriteLine("Saisis le cout de fabrication :");
            int coutFabrication = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le prix de vente :");
            int prixVente = Int32.Parse(Console.ReadLine());
            int marge = prixVente - coutFabrication;
            Console.WriteLine(marge >= 0 ? "Profit de " + marge + " euros" : "Perte de " + -marge + " euros");
        }

        public void Jour()
        {
            Console.WriteLine("\nExercice 5 : numero en jour");
            Console.WriteLine("Saisis un numero entre 1 et 7 :");
            int numero = Int32.Parse(Console.ReadLine());
            string jour;
            switch(numero)
            {
                case 1:
                    jour = "Lundi";
                    break;
                case 2:
                    jour = "Mardi";
                    break;
                case 3:
                    jour = "Mercredi";
                    break;
                case 4:
                    jour = "Jeudi";
                    break;
                case 5:
                    jour = "Vendredi";
                    break;
                case 6:
                    jour = "Samedi";
                    break;
                case 7:
                    jour = "Dimanche";
                    break;
                default:
                    jour = "Ce jour n'existe pas";
                    break;
            }
            Console.WriteLine(numero + " --> " + jour);
        }

        public void Calculatrice()
        {
            Console.WriteLine("\nExercice 6 : calculatrice");
            Console.WriteLine("Saisis un premier operateur :");
            var operande1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Saisis un operande entre + - * ou / :");
            char operateur = Console.ReadLine()[0];
            Console.WriteLine("Saisis un second operateur :");
            float operande2 = float.Parse(Console.ReadLine());
            float result;
            switch(operateur.Equals('+') ? 1 : operateur.Equals('-') ? 2 : operateur.Equals('*') ? 3 : 4)
            {
                case 1:
                    result = operande1 + operande2;
                    break;
                case 2:
                    result = operande1 - operande2;
                    break;
                case 3:
                    result = operande1 * operande2;
                    break;
                default:
                    result = operande1 / operande2;
                    break;
            }
            Console.WriteLine(operande1 + " " + operateur + " " + operande2 + " = " + result);
        }

        public void PairImpair()
        {
            Console.WriteLine("\nExercice 7 : Pair impair");
            Console.WriteLine("Saisis un entier :");
            int @int = Int32.Parse(Console.ReadLine());
            Console.WriteLine(@int % 2 == 0 ? "C'est pair." : "C'est impair");
        }

        public void VoyelleConsonne()
        {
            Console.WriteLine("\nExercice 8 : Voyelle / Consonne");
            Console.WriteLine("Saisis une lettre de l'alphabet :");
            char lettre = Console.ReadKey().KeyChar;
            if(lettre == 'a' || lettre == 'e' || lettre == 'i' || lettre == 'o' || lettre == 'u')
                Console.WriteLine(" --> Voyelle");
            else
                Console.WriteLine(" --> Consonne");
        }

        public void Bissextile()
        {
            Console.WriteLine("\nExercice 9 : Annee bissextile ou non");
            Console.WriteLine("Saisis une annee :");
            int annee = Int32.Parse(Console.ReadLine());
            bool bissextile = false;
            if ((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
                bissextile = true;
            Console.WriteLine(bissextile ? "C'est bissextile" : "Ca n'est pas bissextile");
        }

        public void AlphabetChiffreSymbole()
        {
            Console.WriteLine("\nExercice 10 : Alphabet, Chiffre ou Symbole");
            Console.WriteLine("Saisis n'importe quel caractere :");
            char car = Console.ReadKey().KeyChar;
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chiffre = "0123456789";
            if(alphabet.Contains(car))
                Console.WriteLine(" --> C'est un alphabet");
            else if(chiffre.Contains(car))
                Console.WriteLine(" --> C'est un chiffre");
            else
                Console.WriteLine(" --> C'est un symbole special");


        }

        public void EscalierEtoile()
        {
            string car = "";
            Console.WriteLine("Combien de marches veux-tu monter ?");
            int niveau = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < niveau; i++)
            {
                car += '*';
                Console.WriteLine(car);
            }
        }

        public void PyramideInclinee()
        {
            string car = "";
            Console.WriteLine("Quelle hauteur de sommet pour la pyramide ?");
            int niveau = Int32.Parse(Console.ReadLine());
            int cote = 0;
            do
            {
                for (int i = 0; i < niveau; i++)
                {
                    car = cote == 0 ? car + '*' : car.Remove(car.Length - 1);
                    Console.WriteLine(car);
                }
                cote++;
            } while (cote < 2);
        }

        //TODO
        public void PyramideDroite()
        {
            Console.WriteLine("Quelle largeur pour la base de la pyramide ?");
            int largeur = Int32.Parse(Console.ReadLine());
            int demi = largeur % 2 == 0 ? largeur / 2 : (largeur + 1) / 2;
            string gauche = "", droite = "*";
            //first line : gauche + *
            for(int j = 0; j < demi - 1; j++)
                gauche += '-';

            Console.Write(gauche + droite);

            for(int i = 0; i < largeur; i++)
            {
                //gauche = demi - 1
                //caractere+=2
            }
        }

        public void BouclePrenom()
        {
            string[] prenoms = new string[10]
            {
                "Amine", "Joris", "Rin", "Amelle", "Sabrina",
                "Ségolène", "Floran", "Antoine", "Cyril", "Justin"
            };
            //for (int i = 0; i < prenoms.Length; i++) Console.WriteLine(prenoms[i]);

            //int index = 0; while (index < prenoms.Length) { Console.WriteLine(prenoms[index]); index++; }

            foreach (string p in prenoms) Console.WriteLine(p);
        }

        public void FizzBuzz()
        {
            Console.WriteLine("\nFizzBuzz :\nSaisis un nombre superieur a 14 :");
            int fizz = 3, buzz = 5, stop = Int32.Parse(Console.ReadLine());
            //If %3 & %5 --> FizzBuzz, if %3 --> Fizz, if %5 --> Buzz
            for (int i = 1; i <= stop; i++)
                Console.WriteLine(i % fizz == 0 && i % buzz == 0 ? i + " : FizzBuzz" : i % fizz == 0 ? i + "Fizz" : i % buzz == 0 ? i + "Buzz" : i + "");
        }
    }
}
