using System;

namespace Tp_ProjetBank
{
    class CompteASeuilRemunere : CompteRemunere, ICompteASeuil
    {
        private double seuil;
        public CompteASeuilRemunere() { }
        public CompteASeuilRemunere(int numero, double soldeInitial, double seuil)
        {
            SetNumero(numero);
            SetSolde(soldeInitial);
            this.seuil = seuil;
        }

        public double GetSeuil()
        {
            return this.seuil;
        }
        public void SetSeuil(double seuil)
        {
            this.seuil = seuil;
        }

        public override void Retirer(double valeur)
        {
            double aRetirer = GetSolde() - valeur;
            if (aRetirer > seuil)
            {
                SetSolde(aRetirer);
                Console.WriteLine("Retrait de " + valeur);
            }
            else
                throw new BanqueException("Tentative de retrait > au seuil", new ArgumentOutOfRangeException());
        }

        public override string ToString()
        {
            return base.ToString() + " : seuil = " + seuil;
        }
    }
}
