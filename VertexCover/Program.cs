using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphviz4Net.Graphs;
using Graphviz4Net.Dot;
using VertexCover.GraphDefinition;

namespace VertexCover
{
    public class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Graph graph = new Graph();
            graph.Vertices = new List<Vertex>();
            for (int i = 1; i < 10; i++)
                graph.Vertices.Add(new Vertex() { Value = i });
            graph.Edges = new List<Edge>();

            for (int i = 0; i < 8; i++)
                graph.Edges.Add(new Edge() { From = graph.Vertices[i], To = graph.Vertices[i + 1], IsDeleted = i % 2 == 0 });
            graph.Edges.Add(new Edge() { From = graph.Vertices[graph.Vertices.Count - 1], To = graph.Vertices[0], IsDeleted = false });
            graph.Visualize();
#endif
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
