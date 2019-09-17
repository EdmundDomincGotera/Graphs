using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Edge
    {
        public Edge(int fromVertex, int toVertex)
        {
            FromVertex = fromVertex;
            ToVertex = toVertex;
        }

        public int FromVertex { get; set; }
        public int ToVertex { get; set; }
    }
}
