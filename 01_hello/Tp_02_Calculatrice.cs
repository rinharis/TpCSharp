using System;

namespace _01_hello
{
    public class Tp_02_Calculatrice
    {
        public Tp_02_Calculatrice()
        {
            Calcul();
        }


        public void Calcul()
        {
            do
            {
                Console.WriteLine("Calcul :");
                var operande1 = Operande();
                char operateur = Operateur();
                int operande2 = Operande();
                int result = 0;
                    if (operateur.Equals('+'))
                        result = Addition(operande1, operande2);
                    else if(operateur.Equals('-'))
                        result = Soustraction(operande1, operande2);
                    else if(operateur.Equals('*'))
                        result = Multiplication(operande1, operande2);
                    else
                        result = Division(operande1, operande2);

                Console.WriteLine(operande1 + " " + operateur + " " + operande2 + " = " + result);
            } while (true);

            int Addition(int a, int b)
            {
                return a + b;
            }
            int Soustraction(int a, int b)
            {
                return a - b;
            }
            int Multiplication(int a, int b)
            {
                return a * b;
            }
            int Division(int a, int b)
            {
                return a / b;
            }
            char Operateur()
            {
                char result;
                do
                {
                    Console.WriteLine("Saisis un operateur entre + - * ou / :");
                    result = Console.ReadKey().KeyChar;
                } while (!result.Equals('+') && !result.Equals('-') && !result.Equals('*') && !result.Equals('/'));
                return result;
            }
            int Operande()
            {
                int operande;
                Console.WriteLine("\nSaisis un operande :");
                operande = Convert.ToInt32(Console.ReadLine());
                return operande;
            }
        }

    }
}