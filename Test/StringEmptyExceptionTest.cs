using NUnit.Framework;
using StringExceptions;

namespace Test
{
    public class StringEmptyExceptionTest
    {
        [Test]
        public void WhenStringEmptyExceptionIsCreated_ThenMessageIsTheExpected()
        {
            const string expectedMessage = "Value is an empty string.";
            var exception = new StringEmptyException();

            Assert.AreEqual(expectedMessage, exception.Message);
        }

        [Test]
        public void WhenStringEmptyExceptionIsCreatedWithParameterName_ThenMessageIsTheExpected()
        {
            const string sampleParameterName = "just used to capture its name";

            const string expectedMessage = $"{nameof(sampleParameterName)}: Value is an empty string.";
            var exception = new StringEmptyException(nameof(sampleParameterName));

            Assert.AreEqual(expectedMessage, exception.Message);
        }
    }
}