using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_ProjetArmello
{
    public static class De
    {
        public static int Lance()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
