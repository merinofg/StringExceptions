using System;
using NUnit.Framework;
using StringExceptions;

namespace Test
{
    public class StringNullExceptionTest
    {
        [Test]
        public void WhenStringNullExceptionIsCreated_ThenMessageIsTheExpected()
        {
            var argumentNullException = new ArgumentNullException();
            var exception = new StringNullException();

            Assert.AreEqual(argumentNullException.Message, exception.Message);
        }

        [Test]
        public void WhenStringNullExceptionIsCreatedWithParameterName_ThenMessageIsTheExpected()
        {
            const string sampleParameterName = "just used to capture its name";

            var argumentNullException = new ArgumentNullException(nameof(sampleParameterName));
            var exception = new StringNullException(nameof(sampleParameterName));

            Assert.AreEqual(argumentNullException.Message, exception.Message);
        }
    }
}