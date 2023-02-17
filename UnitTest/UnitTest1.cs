using NUnit.Framework;
using UserRegistration;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("A@dfesf9")]
        [TestCase("0daSkks#lk")]
        [TestCase("aka$H8okde")]
        [TestCase("A4sdfa02kglafg")]
        public void CheckPassword_4_PassingValidInput_ShouldReturnTrue(string userInput)
        {
            Program name = new Program();
            bool expected = true;

            var actual = name.CheckPassword_4(userInput);

            Assert.AreEqual(expected, actual);
        }
    }
}