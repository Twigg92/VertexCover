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
        #endregion
    }
}
