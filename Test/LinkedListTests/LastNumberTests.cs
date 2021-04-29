using FinalProject;
using System;
using Xunit;

namespace Test.LinkedListTests
{
    public class LastNumberTests
    {
        //The last number function of the linked list keeps track of ticket number of the last ticket
        //This is used (+1) when creating new ticket and is important to keep the sequence of ticket numbers

        [Fact]
        public void LastNumberReturnsCorrect()
        {
            //Arrange
            LinkedList LL = new LinkedList(20);
            Ticket t1 = new Ticket(1000, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t3 = new Ticket(1002, "My computer is broken", 1, "Corry Burton");
            Ticket t4 = new Ticket(1003, "My computer is broken", 1, "Corry Burton");
            Ticket t5 = new Ticket(1004, "My computer is broken", 1, "Corry Burton");
            Ticket t6 = new Ticket(1005, "My computer is broken", 1, "Corry Burton");
            Ticket t7 = new Ticket(1006, "My computer is broken", 1, "Corry Burton");
            Ticket t8 = new Ticket(1007, "My computer is broken", 1, "Corry Burton");
            Ticket t9 = new Ticket(1008, "My computer is broken", 1, "Corry Burton");
            Ticket t10 = new Ticket(1009, "My computer is broken", 1, "Corry Burton");
            Ticket t11 = new Ticket(10010, "My computer is broken", 1, "Corry Burton");
            Ticket t12 = new Ticket(1011, "My computer is broken", 1, "Corry Burton");
            Ticket t13 = new Ticket(1012, "My computer is broken", 1, "Corry Burton");
            Ticket t14 = new Ticket(1013, "My computer is broken", 1, "Corry Burton");
            Ticket t15 = new Ticket(1014, "My computer is broken", 1, "Corry Burton");

            LL.addLast(t1);
            LL.addLast(t2);
            LL.addLast(t3);
            LL.addLast(t4);
            LL.addLast(t5);
            LL.addLast(t6);
            LL.addLast(t7);
            LL.addLast(t8);
            LL.addLast(t9);
            LL.addLast(t10);
            LL.addLast(t11);
            LL.addLast(t12);
            LL.addLast(t13);
            LL.addLast(t14);
            LL.addLast(t15);

            //Act
            int last = LL.lastNumber();


            //Assert
            Assert.Equal(t15.Number, last);
        }

        [Fact]
        public void LastNumberDoesntReturnIncorrect()
        {

            //Arrange
            LinkedList LL = new LinkedList(20);
            Ticket t1 = new Ticket(1000, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");

            //Act
            LL.addLast(t1);
            LL.addLast(t2);
            var last = LL.lastNumber();

            //Assert

            Assert.NotEqual(last, t1.Number);

        }


    }
}
