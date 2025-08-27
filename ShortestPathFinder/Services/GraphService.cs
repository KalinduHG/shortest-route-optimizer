using ShortestPathFinder.Models;

namespace ShortestPathFinder.Services
{
    public class GraphService
    {
        public ShortestPathData ShortestPath(string fromNodeName, string toNodeName, List<Node> graph)
        {
            var distances = new Dictionary<string, int>();
            var previous = new Dictionary<string, string>();
            var unvisited = new List<string>();

            foreach (var node in graph)
            {
                distances[node.Name] = int.MaxValue;
                previous[node.Name] = null;
                unvisited.Add(node.Name);
            }

            distances[fromNodeName] = 0;

            while (unvisited.Any())
            {
                var currentNode = unvisited.OrderBy(n => distances[n]).First();
                unvisited.Remove(currentNode);

                if (currentNode == toNodeName)
                    break;

                var nodeObj = graph.First(n => n.Name == currentNode);

                foreach (var edge in nodeObj.Edges)
                {
                    var alt = distances[currentNode] + edge.Weight;
                    if (alt < distances[edge.Target.Name])
                    {
                        distances[edge.Target.Name] = alt;
                        previous[edge.Target.Name] = currentNode;
                    }
                }
            }

            var path = new List<string>();
            var u = toNodeName;
            if (previous[u] != null || u == fromNodeName)
            {
                while (u != null)
                {
                    path.Insert(0, u);
                    u = previous[u];
                }
            }

            return new ShortestPathData
            {
                NodeNames = path,
                Distance = distances[toNodeName] == int.MaxValue ? -1 : distances[toNodeName]
            };
        }
    }
}
