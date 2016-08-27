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

        }

        public Vertex(int value)
        {
            Value = value;
        }
        #endregion

        #region Properties
        public int Value { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
