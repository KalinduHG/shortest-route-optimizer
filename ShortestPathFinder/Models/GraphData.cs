namespace ShortestPathFinder.Models
{
    public static class GraphData
    {
        public static List<Node> GetGraph()
        {

            var a = new Node { Name = "A" };
            var b = new Node { Name = "B" };
            var c = new Node { Name = "C" };
            var d = new Node { Name = "D" };
            var e = new Node { Name = "E" };
            var f = new Node { Name = "F" };
            var g = new Node { Name = "G" };
            var h = new Node { Name = "H" };
            var i = new Node { Name = "I" };

            // A <--> B 4
            a.Edges.Add(new Edge { Target = b, Weight = 4 });
            b.Edges.Add(new Edge { Target = a, Weight = 4 });

            // A <--> C 6
            a.Edges.Add(new Edge { Target = c, Weight = 6 });
            c.Edges.Add(new Edge { Target = a, Weight = 6 });

            // B <--> F 2
            b.Edges.Add(new Edge { Target = f, Weight = 2 });
            f.Edges.Add(new Edge { Target = b, Weight = 2 });

            // F <--> H 6
            f.Edges.Add(new Edge { Target = h, Weight = 6 });
            h.Edges.Add(new Edge { Target = f, Weight = 6 });

            // C <--> D 8
            c.Edges.Add(new Edge { Target = d, Weight = 8 });
            d.Edges.Add(new Edge { Target = c, Weight = 8 });

            // D <--> G 1
            d.Edges.Add(new Edge { Target = g, Weight = 1 });
            g.Edges.Add(new Edge { Target = d, Weight = 1 });

            // E <--> D 4
            e.Edges.Add(new Edge { Target = d, Weight = 4 });
            d.Edges.Add(new Edge { Target = e, Weight = 4 });

            // G <--> I 5
            g.Edges.Add(new Edge { Target = i, Weight = 5 });
            i.Edges.Add(new Edge { Target = g, Weight = 5 });

            // I <--> E 8
            i.Edges.Add(new Edge { Target = e, Weight = 8 });
            e.Edges.Add(new Edge { Target = i, Weight = 8 });

            // G <--> F 4
            g.Edges.Add(new Edge { Target = f, Weight = 4 });
            f.Edges.Add(new Edge { Target = g, Weight = 4 });

            // G <--> H 5
            g.Edges.Add(new Edge { Target = h, Weight = 5 });
            h.Edges.Add(new Edge { Target = g, Weight = 5 });

            // E <--> F 3
            e.Edges.Add(new Edge { Target = f, Weight = 3 });
            f.Edges.Add(new Edge { Target = e, Weight = 3 });

            // E --> B 2
            e.Edges.Add(new Edge { Target = b, Weight = 2 });


            return new List<Node> { a, b, c, d, e, f, g, h, i };
        }
    }
}
