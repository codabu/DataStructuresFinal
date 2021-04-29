using FinalProject;
using Xunit;
using DeepEqual.Syntax;
using System;

namespace Test.PriorityQueueTests
{
    public class GetLLTests
    {
        //In the priority queue the tickets are ordered by ticket priority. The other method of priority queue used in the program
        //is getLL() - these tests check that method is functioning correctly


        [Fact]
        public void GetLLWorks()
        {
            //Arrange
            PriorityQueue pq = new PriorityQueue();
            Ticket t1 = new Ticket(1002, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t3 = new Ticket(1004, "My computer is broken", 1, "Corry Burton");
            Ticket t4 = new Ticket(1003, "My computer is broken", 1, "Corry Burton");
            Ticket t5 = new Ticket(1006, "My computer is broken", 1, "Corry Burton");
            Ticket t6 = new Ticket(1007, "My computer is broken", 1, "Corry Burton");
            Ticket t7 = new Ticket(1005, "My computer is broken", 1, "Corry Burton");
            pq.Enqueue(t1);
            pq.Enqueue(t2);
            pq.Enqueue(t3);
            pq.Enqueue(t4);
            pq.Enqueue(t5);
            pq.Enqueue(t6);
            pq.Enqueue(t7);

            //add the tickets in order of priority to a LL
            LinkedList ll = new LinkedList();
            ll.addLast(t2);
            ll.addLast(t1);
            ll.addLast(t4);
            ll.addLast(t3);
            ll.addLast(t7);
            ll.addLast(t5);
            ll.addLast(t6);

            //Act
            LinkedList getLL = pq.getLL();

            //Assert
            getLL.ShouldDeepEqual(ll);
        }

        [Fact]
        public void GetLLOnEmptyPQReturnsEmptyLL()
        {
            //Arrange
            PriorityQueue pq = new PriorityQueue();

            LinkedList ll = new LinkedList();

            //Act 
            LinkedList getLL = pq.getLL();

            //Assert
            getLL.ShouldDeepEqual(ll);

        }

    }
}
