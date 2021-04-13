using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /***************************************************************
    * Name        : LinkedList
    * Author      : Corry Burton
    * Created     : 2/23/2021
    ***************************************************************/


    /***************************************************************
   * Name        : LinkedList
   * Author      : Corry Burton
   * Created     : 2/23/2021
   ***************************************************************/


    public class LinkedList
    {
        //head of the LL
        private Node Head { get; set; }
        //attribute for size of the LL
        private int Size { get; set; }
        //attribute for maximum size of the LL
        private int MaxSize { get; set; }

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: LinkedList
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/

        public LinkedList()
        {

        }


        /**************************************************************
        * Name: LinkedList
        * Description: Constructor that accepts int for maximum size of the linked list
        * Input: int max
        ***************************************************************/

        public LinkedList(int max)
        {
            Size = 0;
            MaxSize = max;
        }

        /**************************************************************
        * Name: Node
        * Description: Node class that holds a ticket object and points to next node
        * Input: ticket c
        ***************************************************************/
        public class Node
        {
            public Ticket ticket;
            public Node next;
            public Node(Ticket t)
            {
                ticket = t;
                next = null;
            }
        }

        /***************************************************************
        * Class Functions
        ***************************************************************/
        /**************************************************************
        * Name: addLast
        * Description: Adds a new ticket to the end of the linkedList
        * Input: ticket c
        * Output: adds new ticket to end of linkedList
        ***************************************************************/


        public void addLast(Ticket t)
        {
            try
            {
                //check that the linkedList isn't full
                if (Size != MaxSize)
                {
                    //make a new node with the ticket object
                    Node newNode = new Node(t);
                    //set the new nodes next to null
                    newNode.next = null;

                    //when linkedlist is empty set the head
                    if (Size == 0)
                    {
                        //make newNode the head
                        Head = newNode;
                        //increase the size
                        Size++;
                    }

                    //else add the new ticket
                    else
                    {
                        //get a variable for head
                        Node thisNode = Head;
                        //while thisNode.next isn't null, keep moving through the linked list
                        while (thisNode.next != null)
                        {
                            //change thisNode to the nextNode
                            thisNode = thisNode.next;
                        }
                        //add the new node to the end of the linked list
                        thisNode.next = newNode;
                        //increase the size
                        Size++;
                    }
                }

                else throw new FullException();
            }

            catch (FullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        /**************************************************************
        * Name: add
        * Description: Adds a new ticket to specified index of the linkedList
        * Input: int index, ticket c
        * Output: adds new ticket to index of linkedList
        ***************************************************************/
        public void add(int index, Ticket t)
        {
            try
            {
                if (Size != MaxSize)
                {

                    Node newNode = new Node(t);
                    Node temp = Head;
                    for (int i = 1; i < index; i++)
                    {
                        temp = temp.next;
                    }

                    //if the index was 0 make newNode the head
                    if (index == 0)
                    {

                        Head = newNode;
                        newNode.next = temp;
                    }
                    else
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                    }


                    //increase the size
                    Size++;
                }

                else throw new FullException();
            }

            catch (FullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**************************************************************
        * Name: peekFirst
        * Description: displays the first item in the linked list
        * Input: none
        * Output: returns the ticket object from the first node
        ***************************************************************/
        public Ticket peekFirst()
        {
            //if the linkedList has item/items return the first ticket
            if (Size != 0)
            {
                return Head.ticket;
            }
            else throw new EmptyException();
        }
        /**************************************************************
        * Name: removeFirst
        * Description: Removes the first node
        * Input: none
        * Output: Removes the first node
        ***************************************************************/
        public Ticket removeFirst()
        {
            try
            {
                //if the linked list isn't empty, remove the first node
                if (Size != 0)
                {
                    //store the head in an output variable
                    Node output = Head;
                    //Temp node
                    Node temp = Head;
                    //Change the second element to the head
                    Head = temp.next;

                    for (int i = 0; temp != null; i++)
                    {
                        temp = temp.next;
                    }
                    //decrease the size
                    Size--;

                    //return the removed ticket
                    return output.ticket;

                }
                else throw new EmptyException();
            }

            catch (EmptyException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }


        /**************************************************************
        * Name: remove
        * Description: removes a node from a specified index
        * Input: int index
        * Output: removes the node from the specified index
        ***************************************************************/
        public Ticket remove(int index)

        {
            try
            {
                //check that size isn't 0
                if (Size != 0)
                {
                    // Store head node 
                    Node temp = Head;
                    Node toReturn;

                    // If head needs to be removed 
                    if (index == 0)
                    {

                        //variable to return the head
                        toReturn = Head;
                        // Change head 
                        Head = temp.next;
                        return toReturn.ticket;
                    }

                    // Find previous node of the node to be deleted 
                    for (int i = 0;
                            temp != null && i < index - 1;
                            i++)
                        temp = temp.next;

                    // If index is more than number of nodes 
                    if (temp == null || temp.next == null)
                    {
                        throw new ArgumentOutOfRangeException();
                    }


                    // Delete node temp.next
                    // Store pointer to the next of node to be deleted 
                    Node next = temp.next.next;
                    toReturn = temp.next;

                    // Unlink the deleted node from the linked list 
                    temp.next = next;
                    //reduce the size
                    Size--;
                    //Return the deleted ticket
                    return toReturn.ticket;

                }

                else throw new EmptyException();
            }

            catch (EmptyException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }


        /**************************************************************
        * Name: size
        * Description: Returns the size of the linked list
        * Input: none
        * Output: int size of the linked list
        ***************************************************************/

        public int size()
        {
            return Size;
        }

        /**************************************************************
        * Name: display
        * Description: Displays the tickets within the linked list
        * Input: none
        * Output: displays all the tickets in the linked list
        ***************************************************************/

        public List<Ticket> display()
        {
            Node thisNode = Head;
            List<Ticket> output = new List<Ticket>();
            while (thisNode != null)
            {
                output.Add(thisNode.ticket.DisplayTicket());

                thisNode = thisNode.next;
            }

            return output;
        }
    }
}
