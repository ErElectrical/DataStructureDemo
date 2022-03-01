using System;

namespace GraphDataStructureAnalysis
{
    public class Program
    {
        static void Main()
        {
            GraphTraversal graph = new GraphTraversal();
            graph.BFSTraversal(5);
            Console.WriteLine("-----------------------");
            graph.DFSTraversal(0);

        }
    }
}
