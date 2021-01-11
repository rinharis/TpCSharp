using System;

namespace Tp_Heritage
{
    class Marteau
    {
        private string couleur;
        private int poids;

        public Marteau(string couleur, int poids)
        {
            this.couleur = couleur;
            this.poids = poids;
        }

        public virtual void Taper(Qqchose qqchose)
        {
            Console.WriteLine("Objet " + this.GetType().Name + "\t[" + couleur + "\t, " + poids + "g\t] peut taper sur " + qqchose);
        }
    }

    class Qqchose
    {
        public Qqchose() { }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    class Clou : Qqchose
    {
        public override string ToString()
        {
            return this.GetType().Name + ", qui herite de " + this.GetType().BaseType.Name;
        }

    }

}