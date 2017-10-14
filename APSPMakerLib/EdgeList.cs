using System;
using System.Collections.Generic;
using System.Text;

namespace APSPMakerLib
{
    internal class EdgeList
    {
        private Dictionary<(int, int), Edge> edgeList = new Dictionary<(int, int), Edge>();

        public void Add(int start, int end, int length)
        {
            edgeList.Add((start, end), new Edge(start, end, length));
        }

        public bool Contains(int start, int end)
        {
            return edgeList.ContainsKey((start, end));
        }

        public int GetLength(int start, int end)
        {
            return edgeList[(start, end)].length;
        }
    }
}
