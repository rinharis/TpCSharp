//using System;

namespace Tp_ProjetBank
{
    interface ICompteASeuil
    {
        void Retirer(double valeur);
        double GetSeuil();
        void SetSeuil(double seuil);
    }
}
