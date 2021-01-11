using System;
using System.Collections.Generic;

namespace Tp_ProjetBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte compte1 = new Compte(1, 100);
            Compte compte2 = new Compte(2, 1000);
            Compte compte3 = new Compte(3, 10000);
            compte1.Ajouter(100.5);
            compte2.Retirer(499.5);
            compte1.GetNumero();
            compte1.GetSolde();
            Compte[] c1 = new Compte[5];
            c1[0] =compte1;
            c1[1] =compte1;
            c1[2] =compte1;
            c1[3] =compte1;
            c1[4] =compte1;

            Client martin = new Client();
            martin.GetCompte(1);
            martin.GetComptes();
            martin.AjouterCompte(compte1);
            martin.AjouterCompte(compte2);
            martin.AjouterCompte(compte3);
            martin.GetCompte(1);
            martin.GetComptes();
            martin.ToString();

            Client c2 = new Client(10, "DuToto", "Toto", c1);
            c2.ToString();

            CompteRemunere cr1 = new CompteRemunere();
            CompteRemunere cr2 = new CompteRemunere(1, 10000, 0.2);
            cr2.GetTaux();
            cr2.SetTaux(0.1);
            cr2.CalculerInterets();
            cr2.VerserInterets();
            cr2.Retirer(500);
            cr2.Ajouter(3000);
            Console.WriteLine(cr2.ToString());

            CompteASeuil cs1 = new CompteASeuil();
            CompteASeuil cs2 = new CompteASeuil(1, 30000, 20000);
            cs2.GetSeuil();
            cs2.SetSeuil(29000);
            cs2.Retirer(500);
            cs2.Retirer(1000);
            Console.WriteLine(cs2.ToString());

        }
    }
}
