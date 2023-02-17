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
        [TestCase("abc@yahoo.com,")]
        [TestCase("abc-100@yahoo.com,")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com,")]
        [TestCase("abc-100@abc.net,")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc@1.com,")]
        [TestCase("abc@gmail.com.com")]
        [TestCase("abc+100@gmail.com")]

        public void CheckEmailSamples_PassingValidInput_ShouldReturnTrue(string userInput)
        {
            Program name = new Program();
            bool expected = true;

            var actual = name.CheckEmailSamples(userInput);

            Assert.AreEqual(expected, actual);
        }
    }
}