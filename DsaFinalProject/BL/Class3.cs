using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaFinalProject.BL
{
    internal class edgeInfo
    {
        private string edge;
        private int distance;

        public edgeInfo()
        {

        }

        public edgeInfo(string edge, int distance)
        {
            this.Edge = edge;
            this.Distance = distance;
        }

        public string Edge { get => edge; set => edge = value; }
        public int Distance { get => distance; set => distance = value; }
    }
}
