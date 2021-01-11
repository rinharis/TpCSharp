using System;

namespace Tp_ProjetBank
{
    interface ICompteRemunere
    {
        double CalculerInterets();
        void VerserInterets();
        double GetTaux();
        void SetTaux(double taux);
    }
}
