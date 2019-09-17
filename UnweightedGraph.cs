using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class UnweightedGraph<T> : Graph<T>
    {
        public UnweightedGraph(int[,] edges, IList<T> vertices)
        {
            Vertices = vertices;
            CreateAdjacencyList(edges, vertices.Count);
        }

        public UnweightedGraph(int[,] edges, int vertexCount)
        {
            Vertices = new List<T>();

            for (int i = 0; i < vertexCount; i++)
            {
                Vertices.Add(default);
            }

            CreateAdjacencyList(edges, vertexCount);
        }

        public UnweightedGraph(IList<Edge> edges, IList<T> vertices)
        {
            Vertices = vertices;
            CreateAdjacencyList(edges, vertices.Count);
        }
        public UnweightedGraph(IList<Edge> edges, int vertexCount)
        {
            Vertices = new List<T>();

            for (int i = 0; i < vertexCount; i++)
            {
                Vertices.Add(default);
            }

            CreateAdjacencyList(edges, vertexCount);
        }
    }
}
