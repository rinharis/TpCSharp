using System;

namespace _01_hello
{
    class Program
    {
        static void Main(string[] args)
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
            
            int[,] tableau = new int[2, 2]
            {
                {1,2},
                {3,4}
            };

            If_Else_Ternaire();
           
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

    }
}
