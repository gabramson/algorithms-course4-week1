using System;
using System.Collections.Generic;
using System.Text;

namespace APSPMakerLib
{
    internal struct Edge
    {
        public int start;
        public int end;
        public int length;

        public Edge(int start, int end, int length)
        {
            this.start = start;
            this.end = end;
            this.length = length;
        }
    }
}
