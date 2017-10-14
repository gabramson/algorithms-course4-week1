using System;

namespace APSPMakerLib
{
    public class APSPMaker
    {
        private EdgeList edgeList = new EdgeList();
        private VertexList vertexList = new VertexList();

        public bool HasNegativeCycle { private set; get; } = false;
        public int MinPathLength { private set; get; } = -2;

        public void AddEdge(int start, int finish, int length)
        {
            if (!vertexList.ContainsVertex(start))
            {
                vertexList.Add(start);
            }
            if (!vertexList.ContainsVertex(end))
            {
                vertexList.Add(end);
            }
            vertexList.AddNeighbor(start, end);
        }

        public void Execute()
        {

        }
    }
}
