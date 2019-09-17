using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public interface IGraph<T>
    {
        /// <summary>
        /// An instance of a graph with an associated type for its vertices.
        /// </summary>
        int VertexCount { get; }

        /// <summary>
        /// Get the list of vertices in the graph.
        /// </summary>
        IList<T> Vertices { get; }

        /// <summary>
        /// Get the vertex at the specified index.
        /// </summary>
        /// <param name="index">The index of the vertex.</param>
        /// <returns>The vertex at the specified index.</returns>
        T GetVertex(int index);

        /// <summary>
        /// Get the index of the specified vertex.
        /// </summary>
        /// <param name="vertex">The vertex to determine its
        /// index of the underlying container.</param>
        /// <param name="comparer">The comparer used to search
        /// for the specified vertex..</param>
        /// <returns></returns>
        int GetIndex(T vertex);

        /// <summary>
        /// Get the neighbors of a vertex specified by the index.
        /// </summary>
        /// <param name="vertexIndex">The index of the vertex.</param>
        /// <returns>Returns the neighbors of the vertex.</returns>
        IList<T> GetNeighbors(int vertexIndex);

        /// <summary>
        /// Get the neighbors of a vertex (using their indexes) specified by its index.
        /// </summary>
        /// <param name="vertexIndex">The index of the vertex</param>
        /// <returns>Returns the neighbors (by their indexes) of vertex.</returns>
        IList<int> GetNeighborsByIndex(int vertexIndex);

        /// <summary>
        /// Get the degree of the vertex specified by its index.
        /// </summary>
        /// <param name="vertexIndex">The index of the vertex.</param>
        /// <returns>Returns the degree of the vertex (number of neighbors).</returns>
        int GetDegree(int vertexIndex);

        /// <summary>
        /// Get the degree of the vertex specified.
        /// </summary>
        /// <param name="vertex">The vertex to search.</param>
        /// <param name="comparer">The comparer used to search
        /// for the vertex.</param>
        /// <returns>Returns the degree of the vertex.</returns>
        int GetDegree(T vertex, IComparer<T> comparer);

        /// <summary>
        /// Generates the adjacency matrix for the graph.
        /// </summary>
        int[,] AdjacencyMatrix { get; }

        /// <summary>
        /// Get the adjenccy list of the graph.
        /// Contains a list of the vertices and its neighbors.
        /// The neighbors are specified using the index of the vertices.
        /// </summary>
        IList<IList<int>> Neighbors { get; }
    }
}
