using System;

namespace Tp_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo_Heritage_Marteau();
            Point2D_Heritage_Test();
        }

        private static void Demo_Heritage_Marteau()
        {
            Marteau marteau = new Marteau("rouge", 50);
            Qqchose clou = new Clou();
            marteau.Taper(clou);
        }

        private static void Point2D_Heritage_Test()
        {
            Point3D point3D1 = new Point3D(1, 1, 1);
            Point3D point3D2 = new Point3D();
            Point3DBis point3DBis = new Point3DBis(100, 100, 100);
            
            point3D1.Afficher();
            point3D2.Afficher();
           
            Console.WriteLine("Compteur = " + Point2D.compteur);
            
            point3D2.Translater(5, 5);
            point3D2.Afficher();
            point3D2.Translater(10, 10, 10);
            point3D2.Afficher();

            point3DBis.Afficher();
            point3DBis.Translater(500, 500, 500);
            point3DBis.Afficher();
        }
    }
}
