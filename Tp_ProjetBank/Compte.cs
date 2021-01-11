using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_ProjetBank
{
    class Compte
    {
        private int numeroCompte;
        private double solde;

        public Compte() {}

        public Compte(int numero, double solde)
        {
            this.numeroCompte = numero;
            this.solde = solde;
        }

        public int GetNumero()
        {
            return numeroCompte;
        }
        public void SetNumero(int numero)
        {
            this.numeroCompte = numero;
        }
        public double GetSolde()
        {
            return solde;
        }
        
        //Deprecated : utiliser Ajouter() ou Retirer
        public void SetSolde(double solde)
        {
            this.solde = solde;
        }

        public void Ajouter(double unMontant)
        {
            solde += unMontant;
        }
        public virtual void Retirer(double unMontant)
        {
            solde -= unMontant;
        }
        public override string ToString()
        {
            return GetType().Name + " " + numeroCompte + " : solde = " + solde;
        }
    }
}
