using FinalProject;
using Xunit;

namespace Test
{
    public class DisplayTicketTest
    {
        [Fact]
        public void DisplayTicketWorks()
        {
            //Arrange
            Ticket t1 = new Ticket(1001, "My computer is broken", 1, "Corry Burton");
            Ticket t2 = new Ticket(1002, "Internet is down", 2, "Jane Smith");
            int num1 = 1001;
            int num2 = 1002;
            string in1 = "My computer is broken";
            string in2 = "Internet is down";
            int pr1 = 1;
            int pr2 = 2;
            string nam1 = "Corry Burton";
            string nam2 = "Jane Smith";

            //Act & Assert
            Assert.Equal(num1, t1.DisplayTicket().Number);
            Assert.Equal(in1, t1.DisplayTicket().Info);
            Assert.Equal(pr1, t1.DisplayTicket().Priority);
            Assert.Equal(nam1, t1.DisplayTicket().Reporter);

            Assert.Equal(num2, t2.DisplayTicket().Number);
            Assert.Equal(in2, t2.DisplayTicket().Info);
            Assert.Equal(pr2, t2.DisplayTicket().Priority);
            Assert.Equal(nam2, t2.DisplayTicket().Reporter);

        }
    }
}
