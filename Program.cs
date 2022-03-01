using System;

namespace AvlTreeAnalysis
{
    public class Program
    {
        static void Main()
        {
            Node node = new Node();
            AvlTree tree = new AvlTree();
            node = tree.InsertNode(node, 1);
            node = tree.InsertNode(node, 2);
            node = tree.InsertNode(node, 3);
            node = tree.InsertNode(node, 4);
            node = tree.InsertNode(node, 5);

            tree.preorderTraversal(node);





        }
    }
}
