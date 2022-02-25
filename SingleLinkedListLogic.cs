using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAnalysis
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
        public  void InsertFront()
        {
            //Algorithum
            // insert data to Node instance
            // Make the new node points to the head node.
            // Finally, make the new node as the head node.
            Console.WriteLine("Enter Value for Linkedlist ");
            int data = Convert.ToInt32(Console.ReadLine());

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
        public void InsertLast()
        {
            Console.WriteLine("Enter Value for Linkedlist ");
            int data = Convert.ToInt32(Console.ReadLine());
            Node new_Node = new Node(data);
            if (head == null)
            {
                head = new_Node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.Next = new_Node;
        }

        public void InsertAfter()
        {
            Console.WriteLine("Enter Value for Node After which You want Insertion in Linkedlist ");
            int data = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value for new Node for Insertion in Linkedlist ");
            int value = Convert.ToInt32(Console.ReadLine());

            Node temp = this.head;
            Node ReplaceNode = GetNodeOfSpecificData(data);
            Node new_Node = new Node(value);
            new_Node.Next = ReplaceNode.Next;
            ReplaceNode.Next = new_Node;


        }
        /// <summary>
        /// Algorithum
        /// create a temp varible and assign head to it now temp  varible is at head which is starting point of our linkedlist
        /// as at lastnode next donot contains further refernce so we will check untill next has null value
        /// as we get null in next we return the temp node which has refernce of last node
        /// </summary>
        /// <returns></returns>
        /// 

        public Node GetNodeOfSpecificData(int data)
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                
            }
            while(temp.Next.data != data && temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;


        }
        public Node GetLastNode()
        {

            Node temp = this.head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }


        public void display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linkedlist is empty");
            }
            else
            {
                Console.WriteLine("your Linkedlist is : ");
                while (temp != null)
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
            while (temp.Next.Next != null)
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
        public void DeleteNodeOnKey()
        {
            Console.WriteLine("Enter data Value for Linkedlist to delete");
            int key = Convert.ToInt32(Console.ReadLine());
            //store head node
            Node temp = head;
            //prev will store the Previous Node
            Node prev = null;

            //If head itself conatins the key ,
            //then change the refernce of head to temp.Next
            //so that head refernce can be changed.
            if (temp != null && temp.data == key)
            {
                head = temp.Next;
                return;
            }
            //iterate untill dont hit target
            //provide refernce of previous node to prev
            //
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
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
        public void DeleteAtPosition()
        {
            Console.WriteLine("Enter position Value of delete ");
            int pos = Convert.ToInt32(Console.ReadLine());

            //store Head to temp
            Node temp = head;

            //check if head is null or not
            //if head is null its means that linkedlist is empty or not
            if (head == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;

            }
            // if position is zero than change head reference to next pointer
            if (pos == 0)
            {
                head = temp.Next;
                return;
            }
            //traverse untill we get the prev node of position
            for (int i = 0; temp != null && i < pos - 1; i++)
            {
                
                temp = temp.Next;
            }
            if (temp == null || temp.Next == null)
            {
                return;
            }

            //real work of dereferncing takes place here
            //create a new node next and provide it the refernce of next node of deleted node
            Node next = temp.Next.Next;
            //link the next of temp node to next node
            temp.Next = next;
        }

        public void DeleteWholelist()
        {
            head = null;

        }

        public void CountLength()
        {
            Node temp = head;
            if (temp == null)
            {
                return;
            }
            int count = 0;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            Console.WriteLine("length is :{0}", count);

        }


        public void SwapNode()
        {
            Console.WriteLine("Enter first Value for Linkedlist ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second Value for Linkedlist ");
            int y = Convert.ToInt32(Console.ReadLine());

            //make head for linkedlist
            Node head_ref = head;
            //check weather both values are same or not because in this consition no need to move forward.
            if (x == y)
                return;
            //create two new node which temproary stores the data of those node which has specified data.
            Node a = null, b = null;

            while (head_ref.Next != null)
            {
                if (head_ref.Next.data == x)
                    a = head_ref;
                else if (head_ref.Next.data == y)
                    b = head_ref;
                head_ref = head_ref.Next;
            }
            if (a != null && b != null)
            {
                //swapping of node occurs here 
                Node t = a.Next;
                a.Next = b.Next;
                b.Next = t;
                t = a.Next.Next;
                a.Next.Next = b.Next.Next;
                b.Next.Next = t;

            }
        }
        
        /// <summary>
        /// Bubble sort is the simplest sorting algorithum that work by
        /// repeatedly swapping the adjacant elements if they are in wrong order
        /// in bubble sort we took first two elements and place them in correct 
        /// order after doing first pass we have right value at our first place.
        /// and this process moves forward untill we donot get null.
        /// bubble sort can be do in two ways
        /// through passing data
        /// and through passing Node 
        /// we are taking here passing data approach
        ///
        /// 
        /// 
        /// bubble sort takes n-1 pass to sort a linkedlist of n node
        /// </summary>
        public void BubbleSort()
        {
            // check weather head is null or not
            if(head != null)
            {
                //create a instance that will point out to head node further
                Node curr = null;
                //varible responsible to populate while loop
                int status = 0;
                do
                {

                    curr = head;
                    //reinitialise the status to zero so that after each pass we will get its value as zero
                    status = 0;
                    while (curr != null && curr.Next != null)
                    {
                       
                        //swapping of data occur here
                        if (curr.data > curr.Next.data)
                        {
                            status = 1;

                            curr.data = curr.data + curr.Next.data;
                            curr.Next.data = curr.data - curr.Next.data;
                            curr.data = curr.data - curr.Next.data;
                        }
                        //points the head Node to next node
                        curr = curr.Next;
                    }


                } while (status == 1);
            }
            else
            {
                Console.WriteLine("LinkedList is empty");
            }

        }
    }
}
