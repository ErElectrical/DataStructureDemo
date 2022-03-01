using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAnalysis
{
    /// <summary>
    /// In binary search tree root node has two child left child and right child
    /// where left  child always contains less values than root node
    /// where right child always contains value greater than root node
    /// if we find inorder traversal of a Bst tree than it will be a sorted array
    /// this is the best technique to find weather the tree is Bst or not.
    /// </summary>
    public class Node
    {
        //Node class for Bst
        public int data;
        public Node left;
        public Node right;

        public Node()
        {
            left = null;
            right = null;
            data = 0;
        }

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        

        
    }
    public class Binarytree
    {
        public void createNode()
        {


            Node p = new Node(4);//creating root node
            Node p1 = new Node(3);//creating left child
            Node p2 = new Node(6);//creating right child
            
            Node p3 = new Node(2);//creating further Nodes for left and right child
            Node p4 = new Node(5);

            //Linking root node left and right child
            p.left = p1;
            p.right = p2;
            //Linking left child of root node to further node
            p1.left = p3;
            p1.right = p4;

            preorderTraversal(p);
            Console.WriteLine("--------------------------------");
            PostOrderTraversal(p);
            Console.WriteLine("--------------------------------");
            InorderTraveersal(p);
            Console.WriteLine("--------------------------------");

            int opt=IsBst(p);
            if (opt==0)
            {
                Console.WriteLine("Not a Binary search tree");
            }
            else if(opt == 1)
            {
                Console.WriteLine("Yeah a Binary search tree");
            }
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Enter value to be search in Bst");
            int val = Convert.ToInt32(Console.ReadLine());
            Node n = SearchInBstIter(p, val);
            if( n== null)
            {
                Console.WriteLine(" Element Not found ");
            }
            else
            {
                Console.WriteLine("Element found");
            }

            Console.WriteLine("Enter a value to Insert into Bst");
            int insert = Convert.ToInt32(Console.ReadLine());
            InsertInToBst(p,insert);
            InorderTraveersal(p);
            Console.WriteLine("--------------------------------");

            DeletionFromBst(p, insert);
            InorderTraveersal(p);





        }
        /// <summary>
        /// Preorder traversal means 
        /// 1. traverse root node
        /// 2. traverse left node
        /// 3. traverse right node
        /// </summary>
        /// <param name="root"></param>
        public static void  preorderTraversal(Node root)
        {
            if(root != null)
            {
                Console.WriteLine("Element : {0} ", root.data);
                preorderTraversal(root.left);
                preorderTraversal(root.right);
            }
        }

        /// <summary>
        /// Postordertraversl means
        /// 1. traverse left node
        /// 2. traverse right node
        /// 3. traverse root node
        /// </summary>
        /// <param name="root"></param>
        public static void PostOrderTraversal(Node root)
        {
            if(root != null)
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.WriteLine("Element : {0} ", root.data);
            }
        }
        
        /// <summary>
        /// Inorder traversal means
        /// 1.traverse left node 
        /// 2. tarvserse root node
        /// 3. traverse right node
        /// 4. Inorder traversal of a Bst always end up to a sorted array
        /// </summary>
        /// <param name="root"></param>
        public static void InorderTraveersal(Node root)
        {
            if(root != null)
            {
                InorderTraveersal(root.left);
                Console.WriteLine("Element : {0} ", root.data);
                InorderTraveersal(root.right);
            }
        }

        /// <summary>
        /// Algorithum for Check Bst or not
        /// our main task is find weathere inorder traversal of Bst is sorted array or not
        /// 1. initialise a node to take care of prev values
        /// 2. check weather root is null or not if we find root as null than return
        /// 3. check for left subtree
        /// 4. check weather we always find values grtere at prev node side to make assure that next element in inorder traversal 
        ///  is greater than previous node
        /// 5. intialise the root to prev
        /// 6. if all things goes fine than terre is Bst otherwise or not
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int IsBst(Node root)
        {
            Node prev=null;
            if(root != null)
            {
                if(IsBst(root.left) != 1)
                {
                    return 0; 
                }
                if(prev != null && root.data <= prev.data)
                {
                    return 0;
                }
                prev = root;
                return IsBst(root.right);

            }
            else
            {
                return 1;
            }
        }
        /// <summary>
        /// Algorihum for Search in Bst
        /// 1.check weather root is null or not if found null than revert back
        /// 2.when found root data same as given value return true
        /// 3. check weather root data is smaller or greater than given val
        /// 4. if found smaller search on left subtree recursively
        /// 5.if found greater search on right side of subtree recursively.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static Node SearchInBst(Node root,int val)
        {
            if(root == null)
            {
                return null;
            }
            if(val == root.data)
            {
                return root;
            }
            else if(val<root.data)
            {
                return SearchInBst(root.left, val);
            }
            else
            {
                return SearchInBst(root.right, val);
            }
        }
        /// <summary>
        /// Algorihtum for search in Bst is same instead of calling we do this work iteratively
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static Node SearchInBstIter(Node root,int val)
        {
            while(root != null)
            {
                if(val == root.data)
                {
                    return root;
                }
                else if(val < root.data)
                {
                    root = root.left;
                }
                else
                {
                    root = root.right;
                }
            }
            return null;
        }

        /// <summary>
        /// Algorithum to insert in tree
        /// 1. create a prev Node that will take care of previous Node value so that we can keep track of which side we have to move.
        /// 2. keep searching untill we dont reach at leaf node which means untill we dont get null on root.
        /// 3. if value to be inserted is root value than return as Bst tree can not have duplicate value.
        /// 4. else search for place in left side if given value is smaller than root data
        /// 5. if given value is greater than root data than search on right side subtree.
        /// 7. when position found insert the new node
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        public static void InsertInToBst(Node root,int val)
        {
            Node prev = null;
            while(root != null)
            {
                prev = root;
                if(val == root.data)
                {
                    Console.WriteLine("Value can not be inserted \n Bst can not take duplicate value");
                    return ;
                    
                }
                else if(val < root.data)
                {
                    root = root.left;
                }
                else
                {
                    root = root.right;
                }
            }

            Node new_Node = new Node(val);
            if(val < prev.data)
            {
                prev.left = new_Node;
            }
            else
            {
                prev.right = new_Node;
            }


        }
        /// <summary>
        /// Deletion algorithum
        /// 1. as if we delete any node than we have to replace its value of its predeccor or successor
        /// 2. we will choose predeccor value to put at the place of deleted Node .predeccor is nothing but left side value of deleted Node
        ///    where successor is right side value of the deleted node Node ipre keep track of that predeccor node 
        /// 3.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public Node DeletionFromBst(Node root,int val)
        {
            Node ipre= null;
            if(root == null)
            {
                return null;
            }
            if(root.left == null && root.right == null)
            {
                root.left = null;
                root.right = null;
            }
            if(val < root.data )
            {
                root.left=DeletionFromBst(root.left, val);
            }
            else if(val > root.data)
            {
                root.right=DeletionFromBst(root.right, val);
            }
            else
            {
                ipre = inorderPredecessor(root);
                root.data = ipre.data;
                root.left=DeletionFromBst(root.left, ipre.data);
            }
            return root;
        }

        private static Node inorderPredecessor(Node root)
        {
            root = root.left;
            while(root.right != null)
            {
                root = root.right;
            }
            return root;
        }




    }
}
