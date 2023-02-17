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
        [TestCase("Asdfesfh")]
        [TestCase("fdaSkksflk")]
        [TestCase("akashBokde")]
        [TestCase("Asdfaskgladfg")]
        public void CheckPassword_2_PassingValidInput_ShouldReturnTrue(string userInput)
        {
            Program name = new Program();
            bool expected = true;

            var actual = name.CheckPassword_2(userInput);

            Assert.AreEqual(expected, actual);
        }
    }
}