using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaFinalProject.BL
{
    internal class graph
    {
     

        Dictionary<string, List<edgeInfo>> adjList = new Dictionary<string, List<edgeInfo>>();

        public void addEdge(string s, string d, int distance)
        {
            edgeInfo e = new edgeInfo(d, distance);
            adjList[s].Add(e);
            adjList[d].Add(e);
        }

       public void print()
       {
                for (auto lst : adjList)
                {
                    cout << lst.first << "  ";
                }
       }

        Dictionary<string, List<string>> getAdjlist()
        {
                return adjList;
        }
        
    }
}
