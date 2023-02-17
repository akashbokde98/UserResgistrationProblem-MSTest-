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
        [TestCase("91 9584726350")]
        [TestCase("91 9584724218")]
        [TestCase("91 1245826350")]
        [TestCase("91 3984776388")]
        public void CheckPhoneNumber_PassingValidInput_ShouldReturnTrue(string userInput)
        {
            Program name = new Program();
            bool expected = true;

            var actual = name.CheckPhoneNumber(userInput);

            Assert.AreEqual(expected, actual);
        }
    }
}