using System;

namespace Tp_Heritage
{
    class Point3DBis
    {
        // Implémentation de la composition;
        private Point2D point2D = new Point2D();
        private int z;

        public Point3DBis()
        {
        }
        public Point3DBis(int x, int y, int z)
        {
            point2D.SetX(x);
            point2D.SetY(y);
            this.z = z;
        }

        public Point2D GetPoint2D()
        {
            return this.point2D;
        }
        public void SetPoint2D(Point2D point2D)
        {
            this.point2D = point2D;
        }

        public int GetZ()
        {
            return this.z;
        }
        public void SetZ(int z)
        {
            this.z = z >= 0 ? z : this.z;
        }
       

        public  void Translater(int dX, int dY, int dZ)
        {
            Console.WriteLine("Translation de xyz({0}, {1}, {2}) de ({3}, {4}, {5})", point2D.GetX(), point2D.GetY(), GetZ(), dX, dY, dZ);
            point2D.SetX(point2D.GetX() + dX);
            point2D.SetY(point2D.GetY() + dY);
            this.z = z + dZ;
        }

        public void Afficher()
        {
            Console.WriteLine(this.GetType().Name + "\t[" + point2D.GetX() + ", " + point2D.GetY() + ", " + this.GetZ() + "] est composé de Point2D et de l'attribut z");
        }
    }
}
