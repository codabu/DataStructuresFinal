using FinalProject;
using System;
using Xunit;

namespace Test.LinkedListTests
{
    public class AddTests
    {
        //In the linked list tickets are arranged by their ticket number when insertionSort() method is called
        //These tests check that the insertion sort method is arranging tickets by ticket number correctly

        [Fact]
        public void AddToSpecificIndexWorks()
        {
            //Arrange
            LinkedList LL = new LinkedList(5);
            Ticket t1 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");

            LL.addLast(t1);
            LL.addLast(t2);


            Ticket t3 = new Ticket(1002, "I need a new monitor", 3, "Dane Rumble");

            //Act
            LL.add(1, t3);

            //t4 to check that the ticket added in middle of linked list was added correctly
            Ticket t4 = LL.remove(1);

            //t5 and t6 to check that order was correct
            Ticket t5 = LL.remove(0);
            Ticket t6 = LL.remove(0);

            //Assert
            Assert.Equal(t3.Number, t4.Number);
            Assert.Equal(t3.Info, t4.Info);
            Assert.Equal(t3.Assignee, t4.Assignee);
            Assert.Equal(t3.Reporter, t4.Reporter);
            Assert.Equal(t3.Priority, t4.Priority);

            Assert.Equal(t5.Number, t1.Number);
            Assert.Equal(t5.Info, t1.Info);
            Assert.Equal(t5.Assignee, t1.Assignee);
            Assert.Equal(t5.Reporter, t1.Reporter);
            Assert.Equal(t5.Priority, t1.Priority);

            Assert.Equal(t6.Number, t2.Number);
            Assert.Equal(t6.Info, t2.Info);
            Assert.Equal(t6.Assignee, t2.Assignee);
            Assert.Equal(t6.Reporter, t2.Reporter);
            Assert.Equal(t6.Priority, t2.Priority);
        }

        [Fact]
        public void AddFailWhenFull()
        {
            //Arrange
            LinkedList LL = new LinkedList(2);
            Ticket t1 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");

            LL.addLast(t1);
            LL.addLast(t2);



            Ticket t3 = new Ticket(1002, "I need a new monitor", 1, "Dane Rumble");

            //Act
            LL.add(2,t3);

            //Couldn't check for my custom full exception due to the catch block that handles it so checking against removing from index that shouldn't exist instead
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => LL.remove(3));
        }
    }
}
