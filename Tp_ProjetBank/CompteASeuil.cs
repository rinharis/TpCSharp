using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_ProjetBank
{
    class CompteASeuil : Compte
    {
        private double seuil;
        public CompteASeuil() { }
        public CompteASeuil(int numero, double soldeInitial, double seuil)
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
                SetSolde(aRetirer);
            else
                Console.WriteLine("Tentative de retrait > au seuil");
        }

        public override string ToString()
        {
            return base.ToString() + " : seuil = " + seuil;
        }
    }
}
