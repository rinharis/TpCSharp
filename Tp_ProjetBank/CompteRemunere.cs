using System;

namespace Tp_ProjetBank
{
    class CompteRemunere : Compte
    {
        private double taux;

        public CompteRemunere() { }
        public CompteRemunere(int numero, double soldeInitial, double taux)
        {
            SetNumero(numero);
            SetSolde(soldeInitial);
            this.taux = taux;
        }

        public double GetTaux()
        {
            return this.taux;
        }
        public void SetTaux(double taux)
        {
            this.taux = taux;
        }

        public double CalculerInterets()
        {
            return taux * GetSolde();
        }

        public void VerserInterets()
        {
            SetSolde(GetSolde() + CalculerInterets());
        }

        public override string ToString()
        {
            return base.ToString() + " : taux = " + taux;
        }
    }
}
