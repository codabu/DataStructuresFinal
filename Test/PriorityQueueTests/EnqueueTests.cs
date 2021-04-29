using FinalProject;
using Xunit;
using DeepEqual.Syntax;

namespace Test.PriorityQueueTests
{
    public class EnqueueTests
    {
        //In the priority queue the tickets are ordered by ticket priority, where 1 is the highest and 3 is the lowest.
        //These tests check that enqueue works correctly for the priority queue
        

        [Fact]
        public void EnqueueAddsATicket()
        {
            PriorityQueue pq = new PriorityQueue();
            Ticket t1 = new Ticket(1001, "Computer is broke", 2, "User 1");
            pq.Enqueue(t1);

            Ticket t2 = pq.Dequeue();

            t1.ShouldDeepEqual(t2);
        }

        [Fact]
        public void EnqueuePriorityWorks()
        {
            //Low priority = 3, Med = 2, High = 1
            PriorityQueue pq = new PriorityQueue();
            Ticket t1 = new Ticket(1001, "Computer is broke", 3, "User 1");
            Ticket t2 = new Ticket(1002, "Mouse not working", 1, "User 2");
            Ticket t3 = new Ticket(1003, "Internet Down", 2, "User 3");
            pq.Enqueue(t1);
            pq.Enqueue(t2);
            pq.Enqueue(t3);

            Ticket highestPriority = pq.Dequeue();

            t2.ShouldDeepEqual(highestPriority);
        }
        [Fact]
        public void EnqueueSamePriorityOrderWorks()
        {
            //Low priority = 3, Med = 2, High = 1
            PriorityQueue pq = new PriorityQueue();
            Ticket t1 = new Ticket(1001, "Computer is broke", 1, "User 1");
            Ticket t2 = new Ticket(1002, "Mouse not working", 1, "User 2");
            Ticket t3 = new Ticket(1003, "Internet Down", 1, "User 3");
            pq.Enqueue(t1);
            pq.Enqueue(t2);
            pq.Enqueue(t3);

            Ticket highestPriority = pq.Dequeue();

            t1.ShouldDeepEqual(highestPriority);
        }
    }
}
