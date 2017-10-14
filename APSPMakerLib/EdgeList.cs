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
            if (start < end)
            {
                edgeList.Add((start, end), new Edge(start, end, length));
            }
            else
            {
                edgeList.Add((end, start), new Edge(end, start, length));
            }
        }

        public bool Contains(int start, int end)
        {
            if (start < end)
            {
                return edgeList.ContainsKey((start, end));
            }
            else
            {
                return edgeList.ContainsKey((end, start));
            }
        }

        public int GetLength(int start, int end)
        {
            if (start < end)
            {
                return edgeList[(start, end)].length;
            }
            else
            {
                return edgeList[(end, start)].length;
            }
        }
    }
}
