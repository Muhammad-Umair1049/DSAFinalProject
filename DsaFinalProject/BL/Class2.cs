using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

       public void print<K, V>()
       {
            foreach (KeyValuePair<string, List<edgeInfo>> entry in adjList)
            {

                List<edgeInfo> e = new List<edgeInfo>();
                e = entry.Value;
                for (int i = 0; i < e.Count; i++)
                {
                    

                    
                    
                }
            }
        }

        public Dictionary<string, List<edgeInfo>> getAdjlist()
        {
                return adjList;
        }
        
    }
}
