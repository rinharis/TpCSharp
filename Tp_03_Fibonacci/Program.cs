using System;

namespace Tp_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int precedent = 0;
            int suivant = 1;
            int suite = 0;
            Console.Write("Nombre d'iteration :");
            int iteration = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < iteration; i++)
                suite = Calcul();
           
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
}
