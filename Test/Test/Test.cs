using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VertexCover.GraphDefinition;

namespace VertexCover.Tests
{
    [TestFixture]
    public class Test
    {
        Graph MainGraph { get; set; }

        public Test()
        {
            MainGraph = new Graph();
        }

        [Test]
        public void AddVertexWithNeighbor()
        {
            MainGraph.AddVertex(1, new int[]{ 2, 3 });
            Assert.AreEqual(MainGraph.NumberOfVertices, 1);
            Assert.AreEqual(MainGraph.NumberOfEdges, 0);
            Assert.AreEqual(MainGraph.Vertices[0].Value, 1);
            Assert.AreEqual(MainGraph.Vertices[0].N.Count, 0);

            MainGraph.AddVertex(2, new int[] { 1 });
            Assert.AreEqual(MainGraph.NumberOfVertices, 2);
            Assert.AreEqual(MainGraph.NumberOfEdges, 1);
            Assert.AreEqual(MainGraph.Vertices[1].Value, 2);
            Assert.AreEqual(MainGraph.Vertices[0].N.Count, 1);
            Assert.AreEqual(MainGraph.Vertices[1].N.Count, 1);
            Assert.AreEqual(MainGraph.Vertices[0].Edges.Count, 1);
            Assert.AreEqual(MainGraph.Vertices[1].Edges.Count, 1);

            MainGraph.AddVertex(3, new int[] { 1, 2 });
            Assert.AreEqual(MainGraph.NumberOfVertices, 3);
            Assert.AreEqual(MainGraph.NumberOfEdges, 3);
            Assert.AreEqual(MainGraph.Vertices[2].Value, 3);
            Assert.AreEqual(MainGraph.Vertices[0].N.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[1].N.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[2].N.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[0].Edges.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[1].Edges.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[2].Edges.Count, 2);

            MainGraph.AddVertex(4, new int[] { 1 });
            Assert.AreEqual(MainGraph.NumberOfVertices, 4);
            Assert.AreEqual(MainGraph.NumberOfEdges, 4);
            Assert.AreEqual(MainGraph.Vertices[3].Value, 4);
            Assert.AreEqual(MainGraph.Vertices[0].N.Count, 3);
            Assert.AreEqual(MainGraph.Vertices[1].N.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[2].N.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[3].N.Count, 1);
            Assert.AreEqual(MainGraph.Vertices[0].Edges.Count, 3);
            Assert.AreEqual(MainGraph.Vertices[1].Edges.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[2].Edges.Count, 2);
            Assert.AreEqual(MainGraph.Vertices[3].Edges.Count, 1);

            Assert.AreEqual(MainGraph.Vertices[0].Edges[2].To.Value, 4);
            MainGraph.Vertices[0].Edges[1].To.Value = 800;
            Assert.AreEqual(MainGraph.Vertices[2].Value, 800);

            MainGraph.Visualize();
        }

        [Test]
        public void Second()
        {
            Console.WriteLine("DUPA");
            Assert.AreEqual(3, 3);
        }
    }
}
