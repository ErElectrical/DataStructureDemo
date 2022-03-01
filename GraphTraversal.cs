using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructureAnalysis
{
    /// <summary>
    /// A graph can be defined as group of vertices and edges that are used to connect these vertices.
    /// A graph can be seen as a cyclic tree, where the vertices (Nodes) maintain any complex relationship among them instead of having parent child relationship.


    /// </summary>
    public class GraphTraversal
    {
        

        //BFS implementation 
        //Bredth first search


        // it will take care of those nodes which we have visited
        public int[] visited = { 0, 0, 0, 0, 0, 0, 0 };
        // Exploring node array - it is a adjancy matrix array which has information of edges of all the nodes like which node is connected to
        //which node connection of node is shown as 1 where if nodes donot have connection than it will represented as 0.
        public int[,] arr =
        {
                { 0, 1, 1, 1, 0, 0, 0 },
                { 1, 0, 1, 0, 0, 0, 0 },
                { 1, 1, 0, 1, 1, 0, 0 },
                { 1, 0, 1, 0, 1, 0, 0 },
                { 0, 0, 1, 1, 0, 1, 1 },
                { 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0 },
            };

        /// <summary>
        /// Algorithum for Breadth first traversal
        /// it works on queue datastructure as we want to make assure that we never visited a node twice.
        /// </summary>
        /// <param name="i"></param>
        public void BFSTraversal(int i)
        {
            //initalsing queue
            Queue q = new Queue();
            q.size = 100;
            q.front = 0;
            q.rear = 0;
            q.arr = new int[q.size];

            QueueImplementationonArray queue = new QueueImplementationonArray();

            // print the data 
            Console.WriteLine($"{i}");
            //updated it into visited list
            visited[i] = 1;
            //pushing the node into queue.
            queue.enqueue(q, i);

            //traversing untill we dont reach to leaf node which means we traverse whole tree.
            while (!queue.IsEmpty(q))
            {
                // dequeing the node immediately as we visied this node
                int node = queue.dequeue(q);
                //traverse each element of node
                for (int j = 0; j < 7; j++)
                {
                    // checking for edges in adjancy matrix array and visited array
                    if (arr[node, j] == 1 && visited[j] == 0)
                    {
                        //print the data of the node
                        Console.WriteLine($"{j}");
                        //update the visited array to mark we have visited this node
                        visited[j] = 1;
                        //doing enque opreation for next node.
                        queue.enqueue(q, j);
                    }
                }
            }
        }

        /// <summary>
        /// Depth-first search is an algorithm for traversing or searching tree or graph data structures. 
        /// The algorithm starts at the root node (selecting some arbitrary node as the root node in the case of a graph) 
        /// and explores as far as possible along each branch before backtracking.
        /// So the basic idea is to start from the root or any arbitrary node and mark the node and move to the adjacent unmarked node
        /// and continue this loop until there is no unmarked adjacent node. 
        /// Then backtrack and check for other unmarked nodes and traverse them.
        /// Finally, print the nodes in the path.


        /// </summary>
        /// <param name="i"></param>
        public void DFSTraversal(int i)
        {
            stack s = new stack();
            s.size = 100;
            s.top = 0;
            s.arr = new int[s.size];

            StackUsingArray stack = new StackUsingArray();
            Console.WriteLine($"{i}");
            visited[i] = 1;
            stack.Push(s, i);
            while (!stack.IsEmpty(s))
            {

                int node = stack.Pop(s);
                for (int j = 0; j < 7; j++)
                {
                    if (arr[node, j] == 1 && visited[j] == 0)
                    {
                        Console.WriteLine($"{j}");
                        visited[j] = 1;
                        stack.Push(s, j);

                    }
                }
            }
        }
    }
}
