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
        [TestCase("asdfesfh")]
        [TestCase("fdaskksflk")]
        [TestCase("akashbokde")]
        [TestCase("asdfaskgladfg")]
        public void CheckPassword_1_PassingValidInput_ShouldReturnTrue(string userInput)
        {
            Program name = new Program();
            bool expected = true;

            var actual = name.CheckPassword_1(userInput);

            Assert.AreEqual(expected, actual);
        }
    }
}