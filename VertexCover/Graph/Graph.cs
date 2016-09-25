using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCover.GraphDefinition
{
    public class Graph
    {
        #region Fields
        #endregion

        #region Ctor
        public Graph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
            Neighbors = new Edge[][] { };
        }
        #endregion

        #region Properties
        public List<Vertex> Vertices { get; set; }
        public List<Edge> Edges { get; set; }
        public int CurrentVertexIndex { get; private set; }
        public bool IsVertexDeleted { get; }
        public Edge[][] Neighbors { get; set; }
        public int NumberOfVertices { get { return Vertices.Count; } }
        public int NumberOfEdges { get { return Edges.Count; } }
        public bool IsRegular { get; }
        public bool NeedToComputeRegularity { get; }
        #endregion

        #region Methods
        public void Visualize()
        {
            Console.Write("Graph Vertices: ");
            if (Vertices != null && Vertices.Count > 0)
                foreach (var vertex in Vertices)
                    Console.Write(vertex.Value + " ");

            Console.WriteLine("\nGraph structure:");
            if (Edges != null && Edges.Count > 0)
                foreach (var edge in Edges)
                    Console.WriteLine("From: " + edge.From.Value + " To: " + edge.To.Value + " Deleted: " + (edge.IsDeleted ? "Y" : "N"));
        }

        // Dodaj wierzchołek z określonym sąsiedztwem
        public void AddVertex(int value, int[] neighbors)
        {
            Vertex vertex = new Vertex(value);
            List<Vertex> neighborsList = new List<Vertex>();
            foreach (Vertex v in Vertices)
                if (neighbors.Any(x => x.Equals(v.Value)))
                {
                    // stworzenie listy sąsiedztwa i uzupełnienie listy krawędzi
                    neighborsList.Add(v);
                    Edges.Add(new Edge(vertex, v));
                }

            vertex.SetNeighbors(neighborsList);
            Vertices.Add(vertex);
        }
        #endregion
    }
}
