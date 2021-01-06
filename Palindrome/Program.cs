using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Console.WriteLine("Palindrome : symétrie des lettres du mot");
            Console.WriteLine("Saisir un mot palindrome");
            string saisie = Console.ReadLine();
            Console.WriteLine(IsPalindrome(saisie) ? "C'est bien un palindrome!" : "NON !");
        }

        private static bool IsPalindrome(string saisie)
        {
            //separation verticale du mot
            int strLength = saisie.Length;
            int indexSeparation = strLength % 2 == 0 ? strLength / 2 : (strLength / 2) - 1;
            Console.WriteLine(  "index separation = " + indexSeparation);
            bool ok = true;
            //si longeur pair
            for (int i = 0; i < indexSeparation; i++)
            {
                if (!saisie[strLength - i].Equals(saisie[i]))
                    ok = false;
            }

            //si longueur impair
            return ok;
        }
    }
}
