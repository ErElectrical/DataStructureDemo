using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApproach
{
    /// <summary>
    /// The node of a singly linked list contains a data part and a link part. 
    /// The link will contain the address of next node and is initialized to null.
    /// So, we will create class definition of node for singly linked list as follows -

    /// </summary>
    public class Node
    {
        /// <summary>
        /// Singly Linked List:
        /// Singly linked lists contain nodes which have a data part and an address part,
        /// i.e., Next, which points to the next node in the sequence of nodes. 
        /// The next pointer of the last node will point to null.
        /// </summary>
        public int data;
        public Node Next;
        public Node(int d)
        {
            this.data = d;
            this.Next = null;
        }
    }
}
