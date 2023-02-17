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
        [TestCase("abc.xyz@bl.co.in")]
        public void CheckEmailAddress_PassingValidInput_ShouldReturnTrue(string userInput)
        {
            Program name = new Program();
            bool expected = true;

            var actual = name.CheckEmailAddress(userInput);

            Assert.AreEqual(expected, actual);
        }
    }
}