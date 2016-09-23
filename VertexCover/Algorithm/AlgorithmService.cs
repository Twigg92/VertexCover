using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VertexCover.GraphDefinition;

namespace VertexCover.Algorithm
{
    public class AlgorithmService
    {
        public AlgorithmService()
        {

        }

        public void VertexCover(Graph graph, /*Queue queue,*/ int k)
        {
            //if (k <= 7)
            //{
            //    MetodaSilowa();
            //}
            //else
            //{
            //    Reduction();
            //    Struktura struktura = WybierzStrukture();
            //    if (struktura is 2krotka || struktura is DobraPara || struktura is Vertex)
            //        return min(1 + VertexCover(graph \ {z}, queue + (N(z), 2), k-1), 
            //            d(z) + VertexCover(graph \ N[z], queue, k - d(z)));
            //    else 
            //        return min(1 + VertexCover(graph \ {z}, queue, k - 1), 
            //            d(z) + VertexCover(graph \ N[z], queue + (N(u), 2), k - d(z)));
            //}
            // N(z) - sąsiedztwo
        }

        public void Reduction()
        {

        }

        public void WarZwijanie(Graph graph)
        {

        }

        public void WarStrukt(Graph graph)
        {

        }
    }
}
