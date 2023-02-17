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
        [TestCase("Asdfesf9")]
        [TestCase("0daSkksflk")]
        [TestCase("akasH8okde")]
        [TestCase("A4sdfaskglafg")]
        public void CheckPassword_3_PassingValidInput_ShouldReturnTrue(string userInput)
        {
            Program name = new Program();
            bool expected = true;

            var actual = name.CheckPassword_3(userInput);

            Assert.AreEqual(expected, actual);
        }
    }
}