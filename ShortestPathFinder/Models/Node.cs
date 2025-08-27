namespace ShortestPathFinder.Models
{
    public class Node
    {
        public string Name { get; set; }
        public List<Edge> Edges { get; set; } = new();
    }

    public class Edge
    {
        public Node Target { get; set; }
        public int Weight { get; set; }
    }
}
