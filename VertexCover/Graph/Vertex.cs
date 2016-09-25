using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCover.GraphDefinition
{
    public class Vertex
    {
        #region Ctor
        public Vertex()
        {
            N = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public Vertex(int value)
        {
            N = new List<Vertex>();
            Edges = new List<Edge>();
            Value = value;
        }
        #endregion

        #region Properties
        public int Value { get; set; }
        public List<Vertex> N { get; set; }                         // sąsiedztwo
        public List<Edge> Edges { get; set; }                       // wierzchołki
        #endregion

        #region Methods
        public void SetNeighbors(List<Vertex> neighbors)
        {
            N = neighbors;
            foreach (var neighbor in neighbors)
            {
                Edges.Add(new Edge(this, neighbor));
                neighbor.Edges.Add(new Edge(neighbor, this));
                neighbor.N.Add(this);
            }
        }
        #endregion
    }
}
