using System.Collections.Generic;

namespace data_structures
{
    public class Vertex
    {
        public Vertex(string value)
        {
            Value = value;
            Edges = new List<Edge>();
            visited = new Hash();
        }

        public Vertex To(Vertex toVertex, int cost)
        {
            Edges.Add(new Edge(toVertex, cost));


            return this;
        }


        public string Value { get; }
        public List<Edge> Edges { get; private set; }
        Hash visited;


        public void Traverse(Vertex vertex)
        {
            System.Console.WriteLine(vertex.ToString());

            foreach (Edge e in vertex.Edges)
            {
                if (!visited.Contains(e))
                {
                    visited.Add(e);
                    Traverse(e.ToVertex);
                }
            }
        }


        public override string ToString()
        {
            string edgesStr = "";
            foreach (Edge e in Edges)
            { edgesStr += "\n" + e.ToString(); };
            string str = string.Format("Name: {0}, Edges: {1}",this.Value, edgesStr) ;


            return str;
        }
    }

    public class Edge
    {
        private Vertex toVertex;
        private int cost;

        public Edge(Vertex toVertex, int cost)
        {
            this.ToVertex = toVertex;
            this.Cost = cost;
        }

        public Vertex ToVertex { get => toVertex; set => toVertex = value; }
        public int Cost { get => cost; set => cost = value; }

        public override string ToString()
        {
            return string.Format("ToVertex: {0}, Cost: {1}", ToVertex.Value, Cost);
        }
    }
}
