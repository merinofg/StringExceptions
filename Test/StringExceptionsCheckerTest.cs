using System;
using NUnit.Framework;
using StringExceptions;

namespace Test
{
    public class StringExceptionsCheckerTests
    {
        private const string? _string_null = null;
        private const string? _string_with_content = "       ª";
        private const string? _string_empty = "";
        private const string? _string_whitespace = "     ";

        [Test]
        public void WhenThrowIsCalledWithStringContainingText_ThenNothingIsThrown()
        {
            Assert.DoesNotThrow(() => StringExceptionsChecker.Throw(_string_with_content));
        }

        [Test]
        public void WhenThrowIsCalledWithNullString_ThenStringNullExceptionIsThrown()
        {
            var argumentNullException = new ArgumentNullException();

            var exception = Assert.Throws<StringNullException>(
            () => StringExceptionsChecker.Throw(_string_null));

            Assert.That(exception!.Message, Is.EqualTo(argumentNullException.Message));
        }

        [Test]
        public void WhenThrowIsCalledWithNullStringAndParameterName_ThenStringNullExceptionIsThrown()
        {
            var argumentNullException = new ArgumentNullException(nameof(_string_null));

            var exception = Assert.Throws<StringNullException>(
                () => StringExceptionsChecker.Throw(_string_null, nameof(_string_null)));

            Assert.That(exception!.Message, Is.EqualTo(argumentNullException.Message));
        }

        [Test]
        public void WhenThrowIsCalledWithEmptyString_ThenStringEmptyExceptionIsThrown()
        {
            const string expectedMessage = $"Value is an empty string.";

            var exception = Assert.Throws<StringEmptyException>(
            () => StringExceptionsChecker.Throw(_string_empty));

            Assert.That(exception!.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void WhenThrowIsCalledWithEmptyStringAndParameterName_ThenStringEmptyExceptionIsThrown()
        {
            const string expectedMessage = $"{nameof(_string_empty)}: Value is an empty string.";

            var exception = Assert.Throws<StringEmptyException>(
                () => StringExceptionsChecker.Throw(_string_empty, nameof(_string_empty)));

            Assert.That(exception!.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void WhenThrowIsCalledWithWhiteSpace_ThenStringWhiteSpaceExceptionIsThrown()
        {
            const string expectedMessage = "Value only contains whitespaces.";

            var exception = Assert.Throws<StringWhiteSpaceException>(
            () => StringExceptionsChecker.Throw(_string_whitespace));

            Assert.That(exception!.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void WhenThrowIsCalledWithWhiteSpaceAndParameterName_ThenStringWhiteSpaceExceptionIsThrown()
        {
            const string expectedMessage = $"{nameof(_string_whitespace)}: Value only contains whitespaces.";

            var exception = Assert.Throws<StringWhiteSpaceException>(
                () => StringExceptionsChecker.Throw(_string_whitespace, nameof(_string_whitespace)));

            Assert.That(exception!.Message, Is.EqualTo(expectedMessage));
        }
    }
}