using NUnit.Framework;
using StringExceptions;

namespace Test
{
    public class StringWhiteSpaceExceptionTest
    {
        [Test]
        public void WhenStringWhiteSpaceExceptionIsCreated_ThenMessageIsTheExpected()
        {
            const string expectedMessage = "Value only contains whitespaces.";
            var exception = new StringWhiteSpaceException();

            Assert.AreEqual(expectedMessage, exception.Message);
        }

        [Test]
        public void WhenStringWhiteSpaceExceptionIsCreatedWithParameterName_ThenMessageIsTheExpected()
        {
            const string sampleParameterName = "just used to capture its name";

            const string expectedMessage = $"{nameof(sampleParameterName)}: Value only contains whitespaces.";
            var exception = new StringWhiteSpaceException(nameof(sampleParameterName));

            Assert.AreEqual(expectedMessage, exception.Message);
        }

    }
}