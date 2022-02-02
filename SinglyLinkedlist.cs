using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApproach
{
    /// <summary>
    /// When a new Linked List is instantiated,
    /// it just has the head, which is Null.The SinglyLinkedList class will contain nodes of type Node class. 
    /// </summary>
    public class SinglyLinkedlist
    {
        //field varibles
        public Node head;

        /// <summary>
        /// Insert data at front of the Linked List 
        ///The first node, head, will be null when the linked list is instantiated.
        ///When we want to add any node at the front, we want the head to point to it.
        /// We will create a new node.The next of the new node will point to the head of the Linked list.
        ///The previous Head node is now the second node of Linked List because the new node is added at the front.
        ///So, we will assign head to the new node.

        /// </summary>
        /// <param name="data"></param>
        public void InsertFront(int data)
        {
            //Algorithum
            // insert data to Node instance
            // Make the new node points to the head node.
            // Finally, make the new node as the head node.


            //inisite the node class and initialise the data to data varible of Node class
            Node new_Node = new Node(data);
            // giving the refernce of head Node to the Next 
            new_Node.Next = head;
            //now giving the head node the refernce of new node
            head = new_Node;

        }
        /// <summary>
        /// algorithum
        /// craete a new node with given data
        /// check if head is null or not
        /// becasue if head is null than the linkedlist is empty and in this situation we have to start at fresh 
        /// assign the new node to head and return
        /// else we find the last node by GetlastNode method
        /// and points the lastnode next to the new node 
        /// </summary>
        /// <param name="data"></param>
        public void InsertLast(int data)
        {
            Node new_Node = new Node(data);
            if(head == null)
            {
                head = new_Node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.Next = new_Node;
        }
        /// <summary>
        /// Algorithum
        /// create a temp varible and assign head to it now temp  varible is at head which is starting point of our linkedlist
        /// as at lastnode next donot contains further refernce so we will check untill next has null value
        /// as we get null in next we return the temp node which has refernce of last node
        /// </summary>
        /// <returns></returns>
        public Node GetLastNode()
        {
            
            Node temp = this.head;
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

    
        public void display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("linkedlist is empty");
            }
            else
            {
                while(temp != null)
                {
                    Console.WriteLine("  " + temp.data + "  ");
                    temp = temp.Next;
                }
            }
        }
        /// <summary>
        /// Algorithum
        /// first find the last node and than remove its reference from previous node
        /// Create a Node instance and put head in it
        /// traverse untill not get prev to last node 
        /// than remove pointer of last node 
        /// </summary>
        /// <returns></returns>

        public void DeleteLastNode()
        {
            Node temp = head;
            while(temp.Next.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = null;

        }

        /// <summary>
        /// To delete a node from the linked list, we need to do the following steps. 
        ///1) Find the previous node of the node to be deleted.
        ///2) Change the next of the previous node.
        ///3) Free memory for the node to be deleted.
        /// </summary>
        /// <param name="key"></param>
        public void DeleteNodeOnKey(int key)
        {
            //store head node
            Node temp = head;
            //prev will store the Previous Node
            Node prev = null;

            //If head itself conatins the key ,
            //then change the refernce of head to temp.Next
            //so that head refernce can be changed.
            if(temp != null && temp.data == key )
            {
                head = temp.Next;
                return;
            }
            //iterate untill dont hit target
            //provide refernce of previous node to prev
            //
            while(temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.Next;
            }
            if( temp == null)
            {
                return;
            }

            //unlink the node as prev node contains refernce of previous Node
            prev.Next = temp.Next;
        }

        /// <summary>
        /// find the node at that position which is provided
        /// than change refernce of prev node 
        /// </summary>
        /// <param name="pos"></param>
        public void DeleteAtPosition(int pos)
        { 
            //store Head to temp
            Node temp = head;

            //check if head is null or not
            //if head is null its means that linkedlist is empty or not
            if(head == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;

            }
            // if position is zero than change head reference to next pointer
            if(pos==0)
            {
                head = temp.Next;
                return;
            }
            //traverse untill we get the prev node of position
            for(int i=0;temp != null && i<pos-1;i++)
            {
                // 
                temp = temp.Next;
            }
            if(temp==null || temp.Next==null)
            {
                return;
            }

            Node next = temp.Next.Next;
            temp.Next = next;
        }

        public void DeleteWholelist()
        {
            head = null;

        }

        public void CountLength()
        {
            Node temp = head;
            if(temp== null)
            {
                return;
            }
            int count = 0;

            while(temp != null)
            {
                count++;
                temp = temp.Next;
            }
            Console.WriteLine("length is :{0}",count);
            
        }
       
        public void SwapNode(int x,int y)
        {
            Node head_ref = head;
            if (x == y)
                return;
            Node a = null, b = null;
            while(head_ref.Next != null)
            {
                if (head_ref.Next.data == x)
                    a = head_ref;
                else if (head_ref.Next.data == y)
                    b = head_ref;
                head_ref = head_ref.Next;
            }
            if( a != null && b!=null)
            {
                Node t = a.Next;
                a.Next = b.Next;
                b.Next = t;
                t = a.Next.Next;
                a.Next.Next = b.Next.Next;
                b.Next.Next = t;

            }
        }
    }
}

