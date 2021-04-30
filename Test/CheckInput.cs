using System;
using System.Collections.Generic;
using Xunit;
using FinalProject;
namespace Test
{
    public class CheckInput
    {
        [Fact]
        public void TestCheckInvalidNameInput1()
        {
            string reporter = "Jim";
            string info = "asdasdasd asdasdasd asdasdasdasd sadsadasdsda sda sdasda sda sda sda.";
            Validate validate = new Validate();
            string error = validate.CheckInput(reporter, info);
            Console.WriteLine(error);
            Assert.Contains("Please enter a valid name", error);
        }

        [Fact]
        public void TestCheckInvalidNameInput2()
        {
            string reporter = "J";
            string info = "asdasdasd asdasdasd asdasdasdasd sadsadasdsda sda sdasda sda sda sda.";
            Validate validate = new Validate();
            string error = validate.CheckInput(reporter, info);
            Console.WriteLine(error);
            Assert.Contains("Please enter a valid name", error);
        }

        [Fact]
        public void TestCheckInvalidInfoInput1()
        {
            string reporter = "John D'Angelo";
            string info = "Come fix it";
            Validate validate = new Validate();
            string error = validate.CheckInput(reporter, info);
            Console.WriteLine(error);
            Assert.Contains("Please enter more information about the issue", error);
        }
        [Fact]
        public void TestCheckInvalidInfoInput2()
        {
            string reporter = "John D'Angelo";
            string info = "";
            Validate validate = new Validate();
            string error = validate.CheckInput(reporter, info);
            Console.WriteLine(error);
            Assert.Contains("Please enter more information about the issue", error);
        }

        [Fact]
        public void TestCheckValidNameInput1()
        {
            string reporter = "John D'Angelo";
            string info = "asdasdasd asdasdasd asdasdasdasd sadsadasdsda sda sdasda sda sda sda.";
            Validate validate = new Validate();
            string error = validate.CheckInput(reporter, info);
            Console.WriteLine(error);
            Assert.DoesNotContain("Please enter a valid name", error);
            Assert.Equal("", error);
        }

        [Fact]
        public void TestCheckValidNameInput2()
        {
            string reporter = "John Duke-Smith";
            string info = "asdasdasd asdasdasd asdasdasdasd sadsadasdsda sda sdasda sda sda sda.";
            Validate validate = new Validate();
            string error = validate.CheckInput(reporter, info);
            Console.WriteLine(error);
            Assert.DoesNotContain("Please enter a valid name", error);
            Assert.Equal("", error);
        }

        [Fact]
        public void TestCheckValidInfoInput()
        {
            string reporter = "John Duke-Smith";
            string info = "asdasdasd asdasdasd asdasdasdasd sadsadasdsda sda sdasda sda sda sda.";
            Validate validate = new Validate();
            string error = validate.CheckInput(reporter, info);
            Console.WriteLine(error);
            Assert.DoesNotContain("Please enter more information about the issue", error);
            Assert.Equal("", error);
        }
    }
}
