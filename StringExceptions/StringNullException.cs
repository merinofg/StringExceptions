namespace StringExceptions
{
    /// <summary>
    /// Represents an exception for a null string.
    /// </summary>
    public class StringNullException : ArgumentNullException
    {
        /// <inheritdoc />
        public StringNullException()
        {
        }

        /// <inheritdoc />
        public StringNullException(string? paramName) : base(paramName)
        {
        }
    }
}