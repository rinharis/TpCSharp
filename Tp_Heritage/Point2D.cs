using System;

namespace Tp_Heritage
{
    class Point2D
    {
        public static int compteur { get; set; } = 0;
        private int x;
        private int y;

        public Point2D()
        {
            Point2D.compteur++;
            this.SetX(0);
            this.SetY(0);
        }
        public Point2D(int x, int y)
        {
            Point2D.compteur++;
            this.SetX(x);
            this.SetY(y);
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

        /// <summary>
        /// Une méthode pour translater le point (void translater(int dX, int dY)).
        /// On est ici sur une translation vectorielle, la valeur de x devient x+dX et la valeur de y se transforme en y+dY.
        /// </summary>
        /// <param name="dX">int value to add to x</param>
        /// <param name="dY">int value to add to y</param>
        public void Translater(int dX, int dY)
        {
            Console.WriteLine("Translation de xy({0},{1}) de ({2}, {3})", GetX(), GetY(), dX, dY);
            this.SetX(this.GetX() + dX);
            this.SetY(this.GetY() + dY);
        }
        
        public virtual void Afficher()
        {
            Console.WriteLine(this.GetType().Name + "\t[" + this.GetX() + ",\t" + this.GetY() + "\t]");
        }
    }
}
