using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCover.Graph
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
        public int CurrentVertexIndex { get; set; }
        public bool IsVertexDeleted { get; set; }
        public Edge[][] neighbors { get; set; }
        public int numberOfVertices { get; set; }
        public int numberOfEdges { get; set; }
        public bool isRegular { get; set; }
        public bool needToComputeRegularity { get; set; } 
        #endregion
    }
}
