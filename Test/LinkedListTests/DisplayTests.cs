using FinalProject;
using System.Collections.Generic;
using Xunit;
using DeepEqual.Syntax;

namespace Test.LinkedListTests
{
    public class DisplayTests
    {
        //The Display method returns a list of ticket objects - these tests check that this method is functioning correctly

        [Fact]
        public void DisplayReturnsCorrectList()
        {

            //Arrange
            LinkedList LL = new LinkedList(5);
            Ticket ticket1 = new Ticket(1001, "Computer is broke", 2, "User 1");
            Ticket ticket2 = new Ticket(1002, "Monitor not working", 1, "Rob Johnston");
            Ticket ticket3 = new Ticket(1003, "Won't turn on", 3, "Bob Smith");
            Ticket ticket4 = new Ticket(1004, "Makes loud noises", 2, "Kylee Jones");
            Ticket ticket5 = new Ticket(1005, "Internet not working", 3, "Aria Stark");
            LL.addLast(ticket1);
            LL.addLast(ticket2);
            LL.addLast(ticket3);
            LL.addLast(ticket4);
            LL.addLast(ticket5);

            //Act
            List<Ticket> tlist1 = new List<Ticket>() {
            new Ticket(1001, "Computer is broke", 2, "User 1"),
            new Ticket(1002, "Monitor not working", 1, "Rob Johnston"),
            new Ticket(1003, "Won't turn on", 3, "Bob Smith"),
            new Ticket(1004, "Makes loud noises", 2, "Kylee Jones"),
            new Ticket(1005, "Internet not working", 3, "Aria Stark")
            };
            List<Ticket> tlist2 = LL.display();

            //Assert
            for (int i = 0; i < tlist2.Count; i++)
            {
                Ticket t1 = tlist1[i];
                Ticket t2 = tlist2[i];
                t1.ShouldDeepEqual(t2);
            }

        }

        [Fact]
        public void DisplayReturnsCorrectSizeList()
        {

            //Arrange
            LinkedList LL = new LinkedList(5);
            Ticket ticket1 = new Ticket(1001, "Computer is broke", 2, "User 1");
            Ticket ticket2 = new Ticket(1002, "Monitor not working", 1, "Rob Johnston");
            Ticket ticket3 = new Ticket(1003, "Won't turn on", 3, "Bob Smith");
            Ticket ticket4 = new Ticket(1004, "Makes loud noises", 2, "Kylee Jones");
            Ticket ticket5 = new Ticket(1005, "Internet not working", 3, "Aria Stark");
            LL.addLast(ticket1);
            LL.addLast(ticket2);
            LL.addLast(ticket3);
            LL.addLast(ticket4);
            LL.addLast(ticket5);

            //Act
            List<Ticket> tlist1 = new List<Ticket>() {
            new Ticket(1001, "Computer is broke", 2, "User 1"),
            new Ticket(1002, "Monitor not working", 1, "Rob Johnston"),
            new Ticket(1003, "Won't turn on", 3, "Bob Smith"),
            new Ticket(1004, "Makes loud noises", 2, "Kylee Jones"),
            new Ticket(1005, "Internet not working", 3, "Aria Stark")
            };
            List<Ticket> tlist2 = LL.display();

            //Assert
            Assert.Equal(tlist1.Count, tlist2.Count);

        }


    }
}
