using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /***************************************************************
    * Name        : Priority Queue
    * Author      : Corry Burton
    * Created     : 04/12/2021
    ***************************************************************/
    


    public class PriorityQueue
    {
        private LinkedList LL { get; set; }

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: PriorityQueue
        * Description: Default no-arg constructor
        * Input parameters: none
        *   Initializes a LinkedList
        ***************************************************************/

        public PriorityQueue()
        {
            //intialize the LinkedList
            LL = new LinkedList(1000);
        }


        /**************************************************************
        * Name: PriorityQueue
        * Description: Constructor that accepts a LinkedList
        * Input: LinkedList LL
        ***************************************************************/

        public PriorityQueue(LinkedList ll)
        {
            LL = ll;
        }

        /***************************************************************
        * Class Functions
        ***************************************************************/
        /**************************************************************
        * Name: getLL
        * Description: Simple function to return the Linked List
        * Input: None
        * Output: returns the LL field
        ***************************************************************/

        public LinkedList getLL()
        {
            return this.LL;
        }


        /**************************************************************
        * Name: Enqueue
        * Description: Adds a ticket to the priority queue
        * Input: Ticket t
        * Output: Goes through the linked list and inserts the ticket based on its priority
        ***************************************************************/
        public void Enqueue(Ticket t)
        {

            //Ticket object to add to the linkedlist
            Ticket toAdd = t;

            //if the linkedlist is empty, add the node to the front
            if (LL.size() == 0)
            {
                LL.add(0, toAdd);
            }

            else
            {   //temp node starting at the beginning of the Linked List
                var temp = LL.peekFirst();
                int index = 0;

                //if temp is the first node in LL and has lower priority than the node to be added, add the new node before the first
                if (temp.ticket.Priority > toAdd.Priority)
                {
                    LL.add(index, toAdd);
                }

                else
                {
                    //while the priority of temp is lower than the priority of the node to be added and temp.next isn't null, traverse through the linked list
                    while (temp.ticket.Priority <= toAdd.Priority && temp.next != null)
                    {
                        temp = temp.next;
                        index++;
                    }

                    if (temp.next == null)
                    {
                        if (temp.ticket.Priority == toAdd.Priority)
                        {
                            LL.addLast(toAdd);
                            return;
                        }

                        if (temp.ticket.Priority < toAdd.Priority)
                        {
                            LL.add(index + 1, toAdd);
                            return;
                        }
                    }

                    { LL.add(index, toAdd); }
                }
            }

        }

        /**************************************************************
        * Name: Dequeue
        * Description: Dequeue function, not actually used in the program
        * Input: None
        * Output: Takes the first ticket from the program, removes it and returns it
        ***************************************************************/

        /// public Dequeue()
        public Ticket Dequeue()
        {
            Ticket temp = LL.peekFirst().ticket;
            LL.removeFirst();
            return temp;
        }


        /**************************************************************
        * Name: Display
        * Description: Displays the linkedlist
        * Input: None
        * Output: Outputs the tickets in the linkedlist
        ***************************************************************/

        public void Display()
        {
            LinkedList ll = getLL();
            LinkedList.Node thisNode = ll.peekFirst();
            while (thisNode != null)
            {
                thisNode.ticket.DisplayTicket();

                thisNode = thisNode.next;
            }
        }

    }
}
