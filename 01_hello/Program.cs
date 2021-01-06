using System;

namespace _01_hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintFunction();
            //ArrayDeclaration();
            //Downcast();
            //If_Else_Ternaire();
            //OperateursLogiques();
            //Fonctions();

            Tp_01 tp_01 = new Tp_01();
            Tp_02_Calculatrice calculatrice = new Tp_02_Calculatrice();
        }

        private static void Fonctions()
        {
            Addition(6); // 2eme argument optionnel
            int[] tab = { 5, 6, 7, 8, 9 };
            Addition(tab);
            Addition(5, 6, 7, 8); // on peut mettre plus ou moins d'argument
            Addition(a: 12, b: 11, tab); //autre facon d'initialiser les arguments
        }

        private static bool PrintFunction()
        {
            Console.WriteLine("\aHello \n\"World\"!");

            bool b = default;
            Console.WriteLine("Default value of bool : " + b);

            const double PI = Math.PI;
            Console.WriteLine("Declare const double PI : " + PI);

            bool result = PI is double;
            Console.WriteLine("\nPI is double ? " + result + "\n");

            result = true ^ true; Console.WriteLine("true ^ true = " + result);
            result = false ^ false; Console.WriteLine("false ^ false = " + result);
            result = true ^ false; Console.WriteLine("true ^ false = " + result + "\n");

            result = true && true; Console.WriteLine("true && true = " + result);
            result = false && false; Console.WriteLine("false && false = " + result);
            result = true && false; Console.WriteLine("true && false = " + result + "\n");

            result = true | false; Console.WriteLine("true | false = " + result);
            return result;
        }

        private static void ArrayDeclaration()
        {
            int[,] tableau = new int[2, 2]
            {
                {1,2},
                {3,4}
            }; 
        }

        private static void Downcast()
        {
            int @int = 10;
            byte @byte = 8;
            @int = @byte;
            //@byte = @int;
        }
        
        private static void OperateursLogiques()
        {
            bool b = true || false; //true
            b = true && true; // true
        }

        static void If_Else_Ternaire()
        {
            int nbLoop = 0;
            do
            {
                nbLoop++;
                Console.WriteLine("\nQuel age as-tu ?");
                int age = Int32.Parse(Console.ReadLine());
                string text;

                if (age < 18)
                    Console.WriteLine("Tu es mineur");
                else if (age == 18)
                    Console.WriteLine("Tout juste");
                else
                {
                    text = age < 28 ? "Tu es majeur depuis 10 ans ou moins" : "Tu es majeur depuis bien longtemps";
                    Console.WriteLine(text);
                }

                switch(age >= 40 ? 1 : age < 18 ? 3 : 2)
                {
                    case 1:
                        Console.WriteLine( "Tu es très vieux");
                        break;
                    case 2: 
                        Console.WriteLine("Tu es jeune");
                        break;
                    default: 
                        Console.WriteLine("Tu es trop jeune");
                        break;
                }    

            } while (nbLoop < 3);
        }

        /** b : parametre optionnel car initialise */
        static int Addition(int a, int b = 2)
        {
            int result = a + b;
            return result;
        }
        /** params : nombre inconnu de parametres */
        static int Addition(params int[] entiers)
        {
            int result = 0;
            foreach (int valeur in entiers)
                result += valeur;
            return result;
        }

        /// <summary>
        /// Fonction somme des arguments rentres
        /// </summary>
        /// <param name="a">operande1</param>
        /// <param name="b">operande2</param>
        /// <param name="entiers">tableau de taille inconnue a l'avance</param>
        /// <returns></returns>
        static int Addition(int a, int b, params int[] entiers)
        {
            int result = 0;
            foreach (int valeur in entiers)
                result += valeur;
            return result;
        }
        static int Addition(ref int a, ref int b, int c)
        {
            a = 5;
            b = 10;
            c = 15;
            int result = a + b + c;
            return result;
        }

    }
}
