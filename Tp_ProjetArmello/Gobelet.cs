using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_ProjetArmello
{
    class Gobelet
    {
        private List<int> des;

        public List<int> GetDes()
        {
            return this.des;
        }
        public List<int> LanceDe(int nbDe)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nbDe; i++)
                result.Add(De.Lance());
            return result;
        }

        public override string ToString()
        {
            string result = null;
            foreach (int i in des)
                result += i + " ";
            return base.ToString();
        }
    }
}
