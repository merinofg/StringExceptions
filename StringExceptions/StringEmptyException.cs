namespace StringExceptions
{
    /// <summary>
    /// Represents an exception for an empty string.
    /// </summary>
    public class StringEmptyException : Exception
    {
        private const string _message = "Value is an empty string.";

        /// <inheritdoc />
        public StringEmptyException() : base(_message)
        {
        }

        /// <inheritdoc />
        public StringEmptyException(string paramName) : base($"{paramName}: {_message}")
        {
        }
    }
}