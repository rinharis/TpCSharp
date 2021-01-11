using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Heritage
{
    // Héritage
    class Point3D : Point2D
    {
        private int z;
        
        public Point3D()
        {
        }
        public Point3D(int x, int y, int z)
        {
            SetX(x);
            SetY(y);
            this.z = z;
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
            Console.WriteLine("Translation de xyz({0}, {1}, {2}) de ({3}, {4}, {5})", GetX(), GetY(), GetZ(), dX, dY, dZ);
            this.SetX(this.GetX() + dX);
            this.SetY(this.GetY() + dY);
            this.z = z + dZ;
        }

        public override void Afficher()
        {
            Console.WriteLine(this.GetType().Name + "\t[" + this.GetX() + ", " + this.GetY() + ", " + this.GetZ() + "] herite de " + GetType().BaseType.Name);
        }
    }
}
