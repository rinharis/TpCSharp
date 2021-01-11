using System;

namespace Tp_ProjetArmello
{
    class Program
    {
        static void Main(string[] args)
        {
            int test;
            
            //FIXIT : La valeur de De n'est pas modifiee
            Console.WriteLine("De.GetValeur : " + De.GetValeur());
            De.Lance();
            Console.WriteLine("De.GetValeur : " + De.GetValeur());
            De.Lance();
            Console.WriteLine("De.GetValeur : " + De.GetValeur());
            Gobelet g1 = new Gobelet();
            g1.LanceDe(8);
            Console.WriteLine("Goblelet :" + g1.GetDes);


        }
    }
}
