using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_ProjetArmello
{
    static class De
    {
        //FIXIT : comment encapsuler un attribut static dans une classe statique
        private static int valeur;
        public static int GetValeur()
        {
            return De.valeur;
        }
        public static int Lance()
        {
            return new Random().Next(1, 7);
        }
    }
}
