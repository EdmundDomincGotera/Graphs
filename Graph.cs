using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public abstract class Graph<T> : IGraph<T>
    {
        public int VertexCount => Vertices.Count;
        public IList<T> Vertices { get; protected set; }
        public IList<IList<int>> Neighbors => throw new NotImplementedException();
        public int[,] AdjacencyMatrix { get; }

        private int[,] CreateAdjacencyMatrix()
        {
            var adjacencyMatrix = new int[VertexCount, VertexCount];

            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                var neighbors = Neighbors[i];
                foreach (int neighbor in neighbors)
                {
                    adjacencyMatrix[i, neighbor] = 1;
                }
            }

            return adjacencyMatrix;
        }
        public T GetVertex(int index)
        {
            return Vertices[index];
        }
        public int GetIndex(T vertex)
        {
            return Vertices.IndexOf(vertex);
        }
        public IList<T> GetNeighbors(int vertexIndex)
        {
            var vertexNeighbors = new List<T>();

            // translate the int index of neighbots from the adjacency list
            // to the actual vertices.
            foreach (var neighbor in Neighbors[vertexIndex])
            {
                vertexNeighbors.Add(Vertices[neighbor]);
            }

            return vertexNeighbors;
        }

        public IList<int> GetNeighborsByIndex(int vertexIndex)
        {
            return Neighbors[vertexIndex];
        }
        public int GetDegree(int vertexIndex)
        {
            return Neighbors[vertexIndex].Count;
        }

        public int GetDegree(T vertex, IComparer<T> comparer)
        {
            return Neighbors[GetIndex(vertex)].Count;
        }
    }
}
