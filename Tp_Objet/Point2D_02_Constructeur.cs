using System;
using System.Collections.Generic;
using System.Text;

namespace _02_objet
{
    public class Point2D_02_Constructeur
    {
        private int x;
        private int y;

        public Point2D_02_Constructeur()
        {
            this.SetX(0);
            this.SetY(0);
            Afficher();
        }
        public Point2D_02_Constructeur(int x, int y)
        {
            this.SetX(x);
            this.SetY(y);
            Afficher();
        }

        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void Afficher()
        {
            Console.WriteLine(this.GetType().Name + "\t[" + this.GetX() + ",\t" + this.GetY() + "\t]");
        }

        /// <summary>
        /// Une méthode pour translater le point (void translater(int dX, int dY)).
        /// On est ici sur une translation vectorielle, la valeur de x devient x+dX et la valeur de y se transforme en y+dY.
        /// </summary>
        /// <param name="dX">int value to add to x</param>
        /// <param name="dY">int value to add to y</param>
        public void Translater(int dX, int dY)
        {
            this.SetX(this.GetX() + dX);
            this.SetY(this.GetY() + dY);
        }
    }
}
