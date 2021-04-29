using FinalProject;
using System;
using Xunit;

namespace Test.LinkedListTests
{
    public class InsertionSortTests
    {
        //In the linked list tickets are arranged by their ticket number when insertionSort() method is called
        //These tests check that the insertion sort method is arranging tickets by ticket number correctly

        [Fact]
        public void InsertionSortTest1()
        {
            //Arrange
            LinkedList LL = new LinkedList(5);
            Ticket ticket1 = new Ticket(1005, "Computer is broke", 2, "User 1");
            Ticket ticket2 = new Ticket(1003, "Monitor not working", 1, "Rob Johnston");
            Ticket ticket3 = new Ticket(1002, "Won't turn on", 3, "Bob Smith");
            Ticket ticket4 = new Ticket(1001, "Makes loud noises", 2, "Kylee Jones");
            Ticket ticket5 = new Ticket(1004, "Internet not working", 3, "Aria Stark");
            LL.addLast(ticket1);
            LL.addLast(ticket2);
            LL.addLast(ticket3);
            LL.addLast(ticket4);
            LL.addLast(ticket5);


            //Act

            LL.insertionSort();

            //Assert
            int actual = LL.peekFirst().ticket.Number;
            int expected = 1001;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertionSortTest2()
        {
            //Arrange
            LinkedList LL = new LinkedList(10);
            Ticket ticket1 = new Ticket(1005, "Computer is broke", 2, "User 1");
            Ticket ticket2 = new Ticket(1003, "Monitor not working", 1, "Rob Johnston");
            Ticket ticket3 = new Ticket(1002, "Won't turn on", 3, "Bob Smith");
            Ticket ticket4 = new Ticket(1001, "Makes loud noises", 2, "Kylee Jones");
            Ticket ticket5 = new Ticket(1004, "Internet not working", 3, "Aria Stark");
            Ticket ticket6 = new Ticket(1006, "Computer is broke", 2, "User 1");
            Ticket ticket7 = new Ticket(1007, "Monitor not working", 1, "Rob Johnston");
            Ticket ticket8 = new Ticket(1009, "Won't turn on", 3, "Bob Smith");
            Ticket ticket9 = new Ticket(1010, "Makes loud noises", 2, "Kylee Jones");
            Ticket ticket10 = new Ticket(1008, "Internet not working", 3, "Aria Stark");
            LL.addLast(ticket1);
            LL.addLast(ticket2);
            LL.addLast(ticket3);
            LL.addLast(ticket4);
            LL.addLast(ticket5);
            LL.addLast(ticket6);
            LL.addLast(ticket7);
            LL.addLast(ticket8);
            LL.addLast(ticket9);
            LL.addLast(ticket10);


            //Act

            LL.insertionSort();

            //Assert
            int actual = LL.peekFirst().ticket.Number;
            int expected = 1001;
            Assert.Equal(expected, actual);
        }
    }
}
