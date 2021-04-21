using FinalProject;
using System;
using Xunit;

namespace Test
{
    public class NodeTests
    {
        //In the linked list tickets are arranged by their ticket number when insertionSort() method is called
        //These tests check that the insertion sort method is arranging tickets by ticket number correctly

        [Fact]
        public void NodesAreTheSame()
        {
            //Arrange
            LinkedList LL = new LinkedList(5);
            Ticket t1 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");


            //Act
            LL.addLast(t1);

            //Assert

            Assert.Equal(LL.peekFirst().ticket.Info, t2.Info);
            Assert.Equal(LL.peekFirst().ticket.Number, t2.Number);
            Assert.Equal(LL.peekFirst().ticket.Assignee, t2.Assignee);
            Assert.Equal(LL.peekFirst().ticket.Reporter, t2.Reporter);
            Assert.Equal(LL.peekFirst().ticket.Priority, t2.Priority);
        }

        [Fact]
        public void NodesAreDifferent()
        {
            //Arrange
            LinkedList LL = new LinkedList(5);
            Ticket t1 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1002, "My mouse is broken", 2, "Corey Burtonk");


            //Act
            LL.addLast(t1);

            //Assert

            Assert.NotEqual(LL.peekFirst().ticket.Info, t2.Info);
            Assert.NotEqual(LL.peekFirst().ticket.Number, t2.Number);
            //expect assignee to be the same because all new tickets are set to "Unassigned"
            Assert.Equal(LL.peekFirst().ticket.Assignee, t2.Assignee);
            Assert.NotEqual(LL.peekFirst().ticket.Reporter, t2.Reporter);
            Assert.NotEqual(LL.peekFirst().ticket.Priority, t2.Priority);
        }
    }
}
