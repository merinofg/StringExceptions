namespace StringExceptions
{
    public class StringEmptyException : Exception
    {
        private const string _message = "Value is an empty string.";

        public StringEmptyException() : base(_message)
        {
        }

        public StringEmptyException(string paramName) : base($"{paramName}: {_message}")
        {
        }
    }
}