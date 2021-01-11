using System;
using System.Collections.Generic;

namespace Tp_ProjetBank
{
    class Client
    {
        private string nom { get; set; }
        private string prenom { get; set; }
        private int age { get; set; }
        private int numeroClient { get; set; }

        //FIXIT : non initialisé, AjouterCompte ne fonctionne pas
        private Compte[] comptes;
        private const int MAX_NB_COMPTE = 5;
        
        public Client() {}

        public Client(int numeroClient, string nom, string prenom, Compte[] comptes, int age = 14)
        {
            this.numeroClient = numeroClient;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age > 14 ? age : 14;
            foreach(Compte compte in comptes)
                AjouterCompte(compte);
        }

        public Compte GetCompte(int numeroCompte)
        {
            if (this.comptes == null)
                return null;
            for (int i = 0; i < comptes.Length; i++)
            {
                if (!comptes[i].GetNumero().Equals(0) && comptes[i].GetNumero() == numeroCompte)
                    return comptes[i];
            }
            Console.WriteLine("Le numero client " + numeroClient + " ne correspond a aucun compte.");
            return null;
        }
   
        public Compte[] GetComptes()
        {
            Console.WriteLine(GetType().Name + " : methode GetComptes() :");
            if (this.comptes == null)
                return null;
            foreach (Compte compte in comptes)
            {
                if(compte != null)
                    Console.WriteLine(compte.ToString());
            }
            return this.comptes;
        }
        public void AjouterCompte(Compte compte)
        {
            bool isAdded = false;
            if (this.comptes == null)
                this.comptes = new Compte[MAX_NB_COMPTE];
            if (this.comptes.Length <= MAX_NB_COMPTE)
            {
                Console.WriteLine(GetType().Name + " : Ajout du compte " + compte);
                for (int i = 0; i < MAX_NB_COMPTE; i++)
                {
                    if(this.comptes[i] == null && isAdded == false)
                    {
                        this.comptes[i] = compte;
                        isAdded = true;
                    }

                }
            }
            else
                Console.WriteLine("Tentative d'ajout de compte impossible, nombre de compte maximum deja atteint.");
        }

        public override string ToString()
        {
            string client = GetType().Name + " : " + nom + " " + prenom + ", " + age + " ans. Numero client : " + numeroClient + ".";
            for (int i = 0; i < comptes.Length; i++)
            {
                if (comptes[i] != null)
                    client += comptes[i].ToString();
            }
            return client;
        }
    }
}
