using System;

namespace _02_objet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objet : Point2D");
            Console.WriteLine("Classe :");
            Tester_Point2D_Classe();
            Console.WriteLine("\nConstructeur :");
            Tester_Point2D_Constructeur();
            Console.WriteLine("\nStatic :");
            Tester_Point2D_Static();
        }

        private static void Tester_Point2D_Classe()
        {
            Point2D_01_Classe point2D = new Point2D_01_Classe();
            point2D.GetX();
            point2D.GetY();
            point2D.Afficher();
            point2D.SetX(10);
            point2D.SetY(20);
            point2D.Afficher();
            point2D.Translater(50, 50);
            point2D.Afficher();
        }

        private static void Tester_Point2D_Constructeur()
        {
            Point2D_02_Constructeur point2D_Constructeur1 = new Point2D_02_Constructeur();
            Point2D_02_Constructeur point2D_Constructeur2 = new Point2D_02_Constructeur(50, 100);
        }

        private static void Tester_Point2D_Static()
        {
            Point2D_03_Static point2D_Static1 = new Point2D_03_Static();
            Point2D_03_Static point2D_Static2 = new Point2D_03_Static(50, 100);
            Point2D_03_Static point2D_Static3 = new Point2D_03_Static(100, 150);
            
        }
    }
}
