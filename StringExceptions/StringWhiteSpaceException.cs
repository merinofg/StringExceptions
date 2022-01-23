namespace StringExceptions
{
    /// <summary>
    /// Represents an exception for a string that only contains whitespaces.
    /// </summary>
    public class StringWhiteSpaceException : Exception
    {
        private const string _message = "Value only contains whitespaces.";

        /// <inheritdoc />
        public StringWhiteSpaceException() : base(_message)
        {
        }

        /// <inheritdoc />
        public StringWhiteSpaceException(string paramName) : base($"{paramName}: {_message}")
        {
        }
    }
}