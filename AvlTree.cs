using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvlTreeAnalysis
{
    /// <summary>
    /// Node class for Avl tree
    /// </summary>
    public class Node
    {
        public int val;//store value of Node
        public Node left;//self referncing Node instance that will point to left subtree
        public Node right;//self refrncing Node instance that will point to right subtree
        public int height;//height of avl tree

    }
    /// <summary>
    /// Avl tree make the searching in bst as easy as possible
    /// AVL Tree can be defined as height balanced binary search tree in which each node is associated with a balance factor
    /// which is calculated by subtracting the height of its right sub-tree from that of its left sub-tree.

    /// Tree is said to be balanced if balance factor of each node is in between -1 to 1, 
    /// otherwise, the tree will be unbalanced and need to be balanced.

    ///Balance Factor (k) = height (left(k)) - height (right(k))
    /// If balance factor of any node is 1, it means that the left sub-tree is one level higher than the right sub-tree.



     ///If balance factor of any node is 0, it means that the left sub-tree and right sub-tree contain equal height.

     ///If balance factor of any node is -1, it means that the left sub-tree is one level lower than the right sub-tree
    /// </summary>
    public class AvlTree
    {
        /// <summary>
        /// means 
        /// traverse root first
        /// than tarverse left node
        /// than traverse right node
        /// </summary>
        /// <param name="root"></param>
        public void preorderTraversal (Node root)
        {
            if(root != null)
            {
                Console.WriteLine($"Element : { root.val }");
                preorderTraversal(root.left);
                preorderTraversal(root.right);
            }
        }
        public int getheight(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            return root.height;
        }

        public Node createnode(int key)
        {
            Node new_node = new Node();
            new_node.val = key;
            new_node.left = null;
            new_node.right = null;
            new_node.height = 1;

            return new_node;

        
        
        }

        public int getBalanceFactor(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            return root.left.height - root.right.height;
        }

        /// <summary>
        /// Algorihtum for right rotate
        /// 1. create insatnce of node class suppose x and assign root node left to it
        /// 2. create instance of node class suppose t2 and assign right of root node left which is now our previously created node
        /// 3. assign root node left to x
        /// 4. assign x node right to t2.
        /// 5. update the height of both root and x node
        /// 6. retun x which is our rotated node
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public Node rightrotate(Node y)
        {
            Node x = y.left;
            Node t2 = x.right;

            x.right = y;
            y.left = t2;

            y.height = Math.Max(getheight(y.right), getheight(y.left)) + 1;
            x.height = Math.Max(getheight(x.right), getheight(x.left)) + 1;

            return x;



        }

        /// <summary>
        /// Algorihtum for left rotate
        /// 1. create insatnce of node class suppose y and assign root node(x) right to it
        /// 2. create instance of node class suppose t2 and assign left of root node right which is now our previously created node(y)
        /// 3. assign t2 node right to x
        /// 4. assign x to left of y node which basically contain address of root node x right
        /// 5. update the height of both y and x node
        /// 6. retun y which is our rotated node
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Node leftrotate(Node x)
        {
            Node y = x.right;
            Node t2 = y.left;

            y.left = x;
            x.right = t2;

            y.height = Math.Max(getheight(y.right), getheight(y.left)) + 1;
            x.height = Math.Max(getheight(x.right), getheight(x.left)) + 1;

            return y;
        }
        /// <summary>
        /// Algorihtum for InsertNode
        /// 1.check weather root is null or not which means it is a leaf node retun a newly created node than
        /// 2. if given val is less than call recursively insertnode function  for left node of root node
        /// 3. if given val is greter than call recusively insertnode function for right node of root node
        /// 4. update the height of root node
        /// 5. check for balance factor
        /// 6. than based on our balance factor rotation occurs in our avl tree
        ///    to manage the balancefactor of node either -1,0 or 1.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public Node InsertNode(Node root, int val)
        {
            if(root == null)
            {
                return createnode( val);

            }

            if(val < root.val)
            {
                root.left = InsertNode(root.left, val);

            }
            else if( val > root.val)
            {
                root.right = InsertNode(root.right, val);
                return root;
            }

            root.height = 1 + Math.Max(getheight(root.left), getheight(root.right));
            int balancefactor = getBalanceFactor(root);

            //left left case 

            if(balancefactor > 1 && val < root.left.val)
            {
                rightrotate(root);
            }

            //right right case

            if(balancefactor < -1 && val > root.right.val)
            {
                leftrotate(root);
            }

            //left right case

            if(balancefactor > 1 && val > root.left.val)
            {
                root.left = leftrotate(root.left);
                rightrotate(root);
            }

            //right left case 

            if(balancefactor < -1 && val > root.right.val)
            {
                root.right = rightrotate(root.right);
                leftrotate(root);
            }

            return root;





        }

    }
}
