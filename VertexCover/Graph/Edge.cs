using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCover.GraphDefinition
{
    public class Edge
    {
        #region Properties
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Ctor
        public Edge()
        {

        }

        public Edge(Vertex from, Vertex to)
        {
            From = from;
            To = to;
        }
        #endregion

        #region Methods

        public bool IsCoveredBy(Vertex vertex)
        {
            return From == vertex || To == vertex;
        }

        public Edge MkEdge(Vertex a, Vertex b)
        {
            return new Edge() { From = a, To = b, IsDeleted = false };
        }

        public Edge MkEdge(int a, int b)
        {
            return MkEdge(new Vertex(a), new Vertex(b));
        }

        public string Info()
        {
            return string.Format("{0} - {1}", From, To);
        }
        #endregion
    }
}
