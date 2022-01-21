namespace StringExceptions
{
    public class StringWhiteSpaceException : Exception
    {
        private const string _message = "Value only contains whitespaces.";

        public StringWhiteSpaceException() : base(_message)
        {
        }

        public StringWhiteSpaceException(string paramName) : base($"{paramName}: {_message}")
        {
        }
    }
}