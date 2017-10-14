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

        }

        public void Execute()
        {

        }
    }
}
