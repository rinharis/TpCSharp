using System;
using System.Collections.Generic;

namespace Tp_ProjetBank
{
    class Client
    {
        private const int MAX_NB_COMPTE = 5;
        private string nom { get; set; }
        private string prenom { get; set; }
        private int age { get; set; }
        private int numeroClient { get; set; }
        private Dictionary<int, Compte> comptes { get; set; }
        
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
            {
                Console.WriteLine("Ce numero de compte n'existe pas.");
                return null;
            }
            Compte compte = new Compte();
            try
            {
                compte = comptes[numeroCompte];
            }
            catch (Exception e)
            {
                Console.WriteLine("Le numero client " + numeroClient + " ne correspond a aucun compte.");
                throw new BanqueException(e);
            }
            return compte;
        }
   
        public Dictionary<int, Compte> GetComptes()
        {
            Console.WriteLine(GetType().Name + " : methode GetComptes() :");
            if (this.comptes == null)
            {
                Console.WriteLine("Les comptes ne sont pas initialises");
                return null;
            }
            else
                return this.comptes;
        }
        public void AjouterCompte(Compte compte)
        {
            if (this.comptes == null)
            {
                this.comptes = new Dictionary<int, Compte>();
                this.comptes.Add(1, compte);
                Console.WriteLine(GetType().Name + " : Ajout du compte " + compte);
            }
            else if(this.comptes.Count < MAX_NB_COMPTE)
            {
                bool isAdded = false;
                for (int i = 1; i <= MAX_NB_COMPTE; i++)
                {
                    if (!this.comptes.ContainsKey(i) && isAdded == false)
                    {
                        Console.WriteLine(GetType().Name + " : Ajout du compte " + compte);
                        comptes.Add(i, compte);
                        isAdded = true;
                    }
                }
            }
            else
                throw new BanqueException("Ajout de compte impossible, nombre de compte maximum deja atteint.");
        }

        public override string ToString()
        {
            string client = GetType().Name + " : " + nom + " " + prenom + ", " + age + " ans. Numero client : " + numeroClient + ".";

            Dictionary<int, Compte> result = this.comptes;
            foreach (KeyValuePair<int, Compte> i in result)
            {
                client += "\n\t" + i.Key + ", " + i.Value.ToString();
            }
            Console.WriteLine(client);
            return client;
        }
    }
}
