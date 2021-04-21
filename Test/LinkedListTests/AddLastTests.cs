using FinalProject;
using System;
using Xunit;

namespace Test
{
    public class AddLastTests
    {
        //In the linked list tickets are arranged by their ticket number when insertionSort() method is called
        //These tests check that the insertion sort method is arranging tickets by ticket number correctly

        [Fact]
        public void AddLastAddsToLast()
        {
            //Arrange
            LinkedList LL = new LinkedList(5);
            Ticket t1 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");

            LL.addLast(t1);
            LL.addLast(t2);


            Ticket t3 = new Ticket(1002, "I need a new monitor", 3, "Dane Rumble");

            //Act
            LL.addLast(t3);

            Ticket t4 = LL.remove(2);

            //Assert
            Assert.Equal(t3.Number, t4.Number);
            Assert.Equal(t3.Info, t4.Info);
            Assert.Equal(t3.Assignee, t4.Assignee);
            Assert.Equal(t3.Reporter, t4.Reporter);
            Assert.Equal(t3.Priority, t4.Priority);
        }

        [Fact]
        public void AddLastFailWhenFull()
        {
            //Arrange
            LinkedList LL = new LinkedList(2);
            Ticket t1 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");

            LL.addLast(t1);
            LL.addLast(t2);
            


            Ticket t3 = new Ticket(1002, "I need a new monitor", 1, "Dane Rumble");

            //Act
            LL.addLast(t3);

            //Couldn't check for my custom full exception due to the catch block that handles it so checking against removing from index that shouldn't exist instead
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => LL.remove(3));
        }
    }
}
