using System;
using System.Collections.Generic;
using System.Text;

namespace _02_objet
{
    class Point2D_03_Static
    {
        public static int compteur { get; set; } = 0;
        private int x;
        private int y;

        public Point2D_03_Static()
        {
            Point2D_03_Static.compteur++;
            this.SetX(0);
            this.SetY(0);
            Afficher();
        }
        public Point2D_03_Static(int x, int y)
        {
            Point2D_03_Static.compteur++;
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
            this.x = x >= 0 ? x : this.x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void Afficher()
        {
            Console.WriteLine(this.GetType().Name + "\t[" + this.GetX() + ",\t" + this.GetY() + "\t] : instance n° " + Point2D_03_Static.compteur);
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
