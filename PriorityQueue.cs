using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PriorityQueue
    {
        private LinkedList LL { get; set; }
        public PriorityQueue()
        {
            //intialize the LinkedList
            LL = new LinkedList(100);
        }

        public PriorityQueue(LinkedList ll)
        {
            LL = ll;
        }

        public LinkedList getLL()
        {
            return this.LL;
        }

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

        /// public Dequeue()
        public Ticket Dequeue()
        {
            Ticket temp = LL.peekFirst().ticket;
            LL.removeFirst();
            return temp;
        }

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
