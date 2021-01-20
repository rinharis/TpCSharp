using System;
using System.Collections.Generic;
using System.Text;

namespace _01_hello
{
    class TP_03_Fibonacci
    {
        int precedent = 0;
        int suivant = 1;
        int suite = 0;
        public TP_03_Fibonacci()
        {
            Suite();
        }

        public void Suite()
        {
            Console.Write("Nombre d'iteration :");
            int iteration = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < iteration; i++)
                suite = Calcul();
        }
        int Calcul()
        {
            int result = precedent + suivant;
            Console.WriteLine(result);
            precedent = suivant;
            suivant = suite;
            return result;
        }
    }
}
