using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphviz4Net.Graphs;
using Graphviz4Net.Dot;

namespace VertexCover
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<Vertex, Edge> graph = new Graph<Vertex, Edge>();
        }
    }

    public class Vertex
    {
        
    }

    public class Edge : IEdge<Vertex>
    {
        public object Destination
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object DestinationArrow
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object DestinationPort
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object Source
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SourceArrow
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SourcePort
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        Vertex IEdge<Vertex>.Destination
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        Vertex IEdge<Vertex>.Source
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
